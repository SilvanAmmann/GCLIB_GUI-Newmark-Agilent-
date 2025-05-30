﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using AgilentPNA835x;
using System.Diagnostics;
using System.Reflection;

namespace vector_accelerator_project
{
    public partial class Form1 : Form
    {
        // Linking other modules
        private PNA analyzer; //this is an instance of a defined class - look it up!
        private MovementVariables movementVariables;
        private MovementType movementType;

        #region "Variable declaration"
        //global gclib so that other functions can use the most updated one
        //e.g. are we connected or not..
        gclib gclib = null;


        // global persistent variables (used in movementVariables_mm):
        private int myMmToStepper_unitAxisC;
        private int myMmToStepper_unitAxisAB;

        // Cancellation token source to stop the async process
        private CancellationTokenSource _cancellationTokenSource;

        #region "Might remove"

        // for abs_position the coor will be constantly displayed/updated, so I use this method:
        // Accessor function for private variable _abs_position (absolute position of gantry)
        public float[] abs_position
        {
            get { return _abs_position; }
            set
            {
                _abs_position = value;
            }
        }
        private float[] _abs_position = new float[3] {0,0,0};


        //Retrieve absolute position of gantry (Axes a,b, c):
        //Note that retrieval can only be done when the gantry is no longer moving.
        private void cur_abs_pos(float[] abs_position)
        {
            try
            {
                PrintOutput(textBox2, "Updating absolute position.. ", PrintStyle.Normal, true);

                string td_value = gclib.GCommand("PA?,?,?");
       
                // Here onwards we update the variable abs_position:
                coor_string_to_floatArr(td_value, abs_position);

                PrintOutput(textBox2, td_value, PrintStyle.GalilData);
            }
            catch (Exception ex)
            {
                PrintOutput(textBox1, "ERROR in TD command (absolute position): " + ex.Message, PrintStyle.Instruction);
            }
        }
        #endregion
        #endregion

        #region "Initialization of form"
        public Form1()
        {
            InitializeComponent();
            InitializePNA(); // Initializes PNA needed variables, and resets internal "dataPoints" List. Sets analyzer
            
            this.Text = "vector accelerator";
        }

        //Runs when form loads
        private void Form1_Load(object sender, EventArgs e)
        { 
            gclib = new gclib(); //constructor can throw, so SHOULD keep it in a Try block
            movementVariables = new MovementVariables();
            movementType = new MovementType(analyzer, this, gclib/*, ref movementVariables*/); // declaring here for the sole purpose of allowing "general relative movement"

            // UPDATE 30/4/20: Set up persistent variables (used in movementVariables):
            myMmToStepper_unitAxisAB = movementVariables.mmToStepper_unitAxisAB;
            myMmToStepper_unitAxisC = movementVariables.mmToStepper_unitAxisC;


            PrintOutput(textBox1, "Enter a FULL GOpen() address above and press Enter", PrintStyle.Instruction);
            PrintOutput(textBox1, "NOTE: This demo will attempt to move Axis A", PrintStyle.Instruction);

            //this block here to list out available connections
            //make it easier for user to refer to when typing out address
            PrintOutput(textBox1, "Available connections:");
            string[] addrs = gclib.GAddresses();
            if (addrs.Length == 0)
            {
                PrintOutput(textBox1, "None");
            }
            else
            {
                foreach (string a in addrs)
                {
                    PrintOutput(textBox1, a, PrintStyle.GclibData);
                }
            }
            //disable ability to move before a connection with controller has been established
            DisconnectStripButton.Enabled = false; groupBox1.Enabled = false;
            GeneralGroup.Enabled = false; configBox.Enabled = false;
            originButton.Enabled = false; returnOriginButton.Enabled = false;
            btnStop.Enabled = false;
        }
        #endregion

        #region PNA Settings
        private void InitializePNA()
        {
            this.analyzer = new PNA(); //instantiate an object PNA - find out what this does!  
            this.comboBoxMeasure.Items.Insert((int)PNA.MEASUREMENT.S11, "S11"); //give it the properties entered in the form
            this.comboBoxMeasure.Items.Insert((int)PNA.MEASUREMENT.S12, "S12");
            this.comboBoxMeasure.Items.Insert((int)PNA.MEASUREMENT.S21, "S21");
            this.comboBoxMeasure.Items.Insert((int)PNA.MEASUREMENT.S22, "S22");

            this.comboBoxMeasure.SelectedIndex = (int)PNA.MEASUREMENT.S11; // default measurement setting

            // UPDATE 15/4: fix for format changing. 
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.LinMag, "Linear Magnitude");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.LogMag, "Log Magnitude");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.Phase, "Phase");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.Polar, "Polar");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.Smith, "Smith");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.Delay, "Delay");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.Real, "Real");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.Imaginary, "Imaginary");
            this.comboBoxFormat.Items.Insert((int)PNA.FORMAT.SWR, "SWR");
           

            this.comboBoxFormat.SelectedIndex = (int)PNA.FORMAT.LinMag;
        }

        private void numericUpDownPoints_ValueChanged(object sender, EventArgs e)
        {
            
        }
        #endregion


        #region "Events to export"
        // Events to export
        public bool mmButton_checked()
        {
            return mmButton.Checked;
        }
        #endregion

        #region "Helper functions"

        // Handler when "unit of measure" buttons events fire:
        private void unitChangeHandler()
        {
            if (mmButton.Checked || stepperButton.Checked)
            {
                on_unitSelected();
                if (mmButton.Checked)
                {
                    movementVariables = new MovementVariables_mmUnit();
                    label5.Text = "Distance in\r\nmm (>1mm):\r\n";
                    label21.Text = "Slew Speed (mm/s):";
                }
                else if (stepperButton.Checked)
                {
                    movementVariables = new MovementVariables_stepperUnit();
                    label5.Text = "Distance in\r\nStepper Units (>300):\r\n";
                    label21.Text = "Slew Speed (Stepper Units/s):";
                }

                movementVariables.mmToStepper_unitAxisAB = myMmToStepper_unitAxisAB;
                movementVariables.mmToStepper_unitAxisC = myMmToStepper_unitAxisC;
            }
        }

        // From string from textBox, to X, Y, Z coordinates in int array:
        private void coor_string_to_floatArr(string text, float[] prev_position)
        {
            int[] arr = new int[3];

            try
            {
                string[] parts = text.Split(new[] { ", " }, StringSplitOptions.None);

                if (!float.TryParse(parts[0], out prev_position[0])) prev_position[0] = arr[0];
                if (!float.TryParse(parts[1], out prev_position[1])) prev_position[1] = arr[1];
                if (!float.TryParse(parts[2], out prev_position[2])) prev_position[2] = arr[2];
            }
            catch (Exception ex)
            {
                PrintOutput(textBox1, "ERROR in converting text to float: " + ex.Message, PrintStyle.Instruction);
                // revert back to previous values.  
                prev_position[2] = arr[2]; prev_position[1] = arr[1]; prev_position[0] = arr[0]; 
            }
        }


        //display for textbox4 : displays variables in groupBox1
        private void display_textbox4_manual()
        {   
            textBox4.Clear();
            textBox4.Text += "Start position: " + movementVariables.Start_position[0] + ", " 
                + movementVariables.Start_position[1] + ", "
                + movementVariables.Start_position[2] + Environment.NewLine;

            movementVariables.Intermediate_positions?.ForEach(a => {
                textBox4.Text += "Intermediate position: " + a[0] + ", " + a[1] + ", " + a[2] + Environment.NewLine;
            });
            textBox4.Text += "End position: " + movementVariables.End_position[0] + ", " 
                + movementVariables.End_position[1] + ", "
                + movementVariables.End_position[2] + Environment.NewLine;
            textBox4.Text += "Drop bar by: " + movementVariables.Axis_c_drop_by + Environment.NewLine;
        }
      
        private void display_textbox4_segment()
        {
            textBox4.Clear();
            int counter = 1;
            //here we display completed/validated segments:
            movementVariables.Segment_positions?.ForEach(a => {
                if (counter != movementVariables.Segment_positions.Count)
                {
                    textBox4.Text += "Segment " + counter + ".. " + Environment.NewLine;
                    textBox4.Text += "A(start): " + a[0] + ", A(end): " + a[1] + ", delta A: " + a[2] + Environment.NewLine;
                    textBox4.Text += "B(start): " + a[3] + ", B(end): " + a[4] + ", delta B: " + a[5] + Environment.NewLine;
                    textBox4.Text += "C(start): " + a[6] + ", C(end): " + a[7] + ", delta C: " + a[8] + Environment.NewLine + Environment.NewLine;
                    counter += 1;
                }
            });
            //here we display the segment that that the user is currently trying to input:
            if (movementVariables.Segment_positions.Count > 0)
            {
                int[] b = movementVariables.Segment_positions.Last();
                textBox4.Text += "Current segment input.. : " + Environment.NewLine;
                textBox4.Text += "A(start): " + b[0] + ", A(end): " + b[1] + ", delta A: " + b[2] + Environment.NewLine;
                textBox4.Text += "B(start): " + b[3] + ", B(end): " + b[4] + ", delta B: " + b[5] + Environment.NewLine;
                textBox4.Text += "C(start): " + b[6] + ", C(end): " + b[7] + ", delta C: " + b[8] + Environment.NewLine + Environment.NewLine;

            }
            textBox4.Text += "Drop bar by: " + movementVariables.Axis_c_drop_by + Environment.NewLine;
            textBox4.Text += "Even Row Offset: " + movementVariables.Even_row_offset + Environment.NewLine;
        }

        //Various print styles.
        public enum PrintStyle
        {
            Instruction,
            Normal,
            GalilData,
            GclibData,
            Err,
        }

        private void PrintOutput(System.Windows.Forms.RichTextBox Output, string Message, PrintStyle Style = PrintStyle.Normal, bool SuppressCrLf = false)
        {
            if (Output.InvokeRequired)
            {
                Output.Invoke(new Printer(PrintOutput), new object[] { Output, Message, Style, SuppressCrLf });
            }
            else
            {
                Color color;

                switch (Style)
                {
                    case PrintStyle.Instruction:
                        color = Color.Black;
                        break;
                    case PrintStyle.GalilData:
                        color = Color.Green;
                        break;
                    case PrintStyle.Normal:
                        color = Color.Blue;
                        break;
                    case PrintStyle.Err:
                        color = Color.Red;
                        break;
                    case PrintStyle.GclibData:
                        color = Color.Magenta;
                        break;
                    default:
                        color = Color.Blue;
                        break;
                }//switch

                Output.SelectionStart = Output.Text.Length;
                Output.SelectionColor = color;
                Output.AppendText(Message);

                if (!SuppressCrLf)
                    Output.AppendText("\r\n");

            }//invoke check
        }


        public void printTextBox1(string a, PrintStyle printStyle = PrintStyle.Normal)
        {
            PrintOutput(textBox1, a, printStyle, true);
        }
        #endregion

        #region "Threading"

        /// <summary>
        /// Delegate used to print status when the status is generated in a thread other than the UI thread.
        /// </summary>
        /// <param name="Message">Message to print</param>
        /// <param name="Style">Print Style</param>
        /// <param name="SuppressCrLf">If true, the string will be printed without a trailing cr+lf</param>
        private delegate void Printer(RichTextBox Output, string Message, PrintStyle Style, bool SuppressCrLf);


        /// <summary>
        /// Fires up the demo via the background worker thread
        /// AS OF NOW, this function is not utilized
        /// </summary>
        /// <param name="address">The full GOpen() addresss<</param>
        /// <remarks>Runs in UI thread</remarks>
        private void RunDemo(string address)
        {
            MainToolStrip.Enabled = false;
            DisconnectStripButton.Enabled = true;

            textBox1.Clear();
            textBox2.Clear();
            GClibBackgroundWorker1.RunWorkerAsync(address);
        }


        /// <summary>
        /// Runs in second thread to call the demo.
        /// </summary>
        private void GClibBackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            PrintOutput(textBox1, "Running Demo with address " + e.Argument, PrintStyle.Normal);
            Main((string)e.Argument); //call the actual demo code
        }

        /// <summary>
        /// Runs in the main thread after the second thread returns. Currently unused.
        /// </summary>
        private void GClibBackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PrintOutput(textBox1, "Demo thread done.", PrintStyle.Normal);
            MainToolStrip.Enabled = true;
            DisconnectStripButton.Enabled = false;
        }
        #endregion


        #region "Completed control implementations"

        #region "Unit of measure related controls"
        private void mmButton_CheckedChanged(object sender, EventArgs e)
        {
            if(mmButton.Checked)
                unitChangeHandler();
        }

        private void stepperButton_CheckedChanged(object sender, EventArgs e)
        {
            if(stepperButton.Checked)
                unitChangeHandler();
        }
        #endregion


        #region "Gclib connection button controls"
        private void ConnectStripButton_Click(object sender, EventArgs e)
        {
            //only checking for empty string, otherwise we enter the Main program.
            //because invalid address will itself trigger an exception, exiting the Main program. 
            if(AddressTextBox.Text.Length == 0)
            {
                PrintOutput(textBox1, "Cannot be Null. Enter a FULL GOpen() address above and click Go", PrintStyle.Instruction);
                return;
            }
            try
            {   
                string address = AddressTextBox.Text;
                PrintOutput(textBox1, "Opening connection to \"" + address + "\"... ", PrintStyle.Normal, true);
                gclib.GOpen(address);
                PrintOutput(textBox1, "CONNECTED!", PrintStyle.Normal);
                PrintOutput(textBox1, gclib.GInfo(), PrintStyle.GalilData);

                //Now that we've successfully connected, here we modify how user
                //can interact with the GUI:
                DisconnectStripButton.Enabled = true; ConnectStripButton.Enabled = false;
                AddressTextBox.Enabled = false;
                configBox.Enabled = true;

                this.analyzer.Open(); // meaning, we activate analyzer as soon as connect button is pressed.

                // Call this multiple times, as a warm up. 
                // Previous problem: there would be nothing (or problems) to read from Gclib.message() if we don't call the preceding Gclib commands multiple times
                cur_abs_pos(abs_position);
                cur_abs_pos(abs_position);
                cur_abs_pos(abs_position);

                return;
            }
            catch (Exception ex)
            {
                PrintOutput(textBox1, "ERROR: " + ex.Message, PrintStyle.Instruction);
                PrintOutput(textBox1, "Invalid address. Re-enter a FULL GOpen() address above and click Go", PrintStyle.Instruction);
                return;
            }
        }

        private void DisconnectStripButton_Click(object sender, EventArgs e)
        {
            gclib.GClose();
            AddressTextBox.Enabled = true;
            ConnectStripButton.Enabled = true;

            DisconnectStripButton.Enabled = false; groupBox1.Enabled = false;
            GeneralGroup.Enabled = false; configBox.Enabled = false;
            originButton.Enabled = false; returnOriginButton.Enabled = false;
            mmButton.Checked = false; stepperButton.Checked = false;

            this.analyzer.Close();

            PrintOutput(textBox1, "DISCONNECTED!", PrintStyle.Normal);
        }
        #endregion

        #region "Relative movement button controls"
        // general movement, + axis-a incremental movement button: 
        private void button1_Click(object sender, EventArgs e)
        {
            //take a single button click as moving 10000 units in a-axis
            movementType.runRelativeMoveCommand("A", movementVariables.Increment_unit_a, movementVariables.Speed_a);

            cur_abs_pos(abs_position);
        }

        // general movement, - axis-a incremental movement button: 
        private void button2_Click(object sender, EventArgs e)
        {
            movementType.runRelativeMoveCommand("A", -1 * movementVariables.Increment_unit_a, movementVariables.Speed_a);
            cur_abs_pos(abs_position);
        } 

        // general movement, + axis-b incremental movement button: 
        private void button4_Click(object sender, EventArgs e)
        {
            movementType.runRelativeMoveCommand("B", movementVariables.Increment_unit_b, movementVariables.Speed_b);
            cur_abs_pos(abs_position);
        }

        // general movement, - axis-b incremental movement button: 
        private void button3_Click(object sender, EventArgs e)
        {
            movementType.runRelativeMoveCommand("B", -1 * movementVariables.Increment_unit_b, movementVariables.Speed_b);
            cur_abs_pos(abs_position);
        }

        // general movement, + axis-c incremental movement button: 
        private void button6_Click(object sender, EventArgs e)
        {
            movementType.runRelativeMoveCommand("C", movementVariables.Increment_unit_c, movementVariables.Speed_c);
            cur_abs_pos(abs_position);
        }

        // general movement, - axis-c incremental movement button: 
        private void button5_Click(object sender, EventArgs e)
        {
            movementType.runRelativeMoveCommand("C", -1 * movementVariables.Increment_unit_c, movementVariables.Speed_c);
            cur_abs_pos(abs_position);
        }
        #endregion

        // GUI components to enable once a unit (either mm or stepper count) is selected:
        private void on_unitSelected()
        {
            groupBox1.Enabled = true;
            GeneralGroup.Enabled = true;
            originButton.Enabled = true; returnOriginButton.Enabled = true;
            axisCinputBox.Enabled = false; manualBox.Enabled = false; segmentBox.Enabled = false; rowOffsetBox.Enabled = false;

            //Also Update gantry absolute position to variable abs_position:
            cur_abs_pos(abs_position);
        }

        #region "Manual movement controls + some common controls"

        #region "Other parameter input textbox related controls: 

        // Set number of units to drop axis-c, according to input from textBox5: 
        private void button11_Click(object sender, EventArgs e)
        {
            float value = 0;
            float.TryParse(textBox5.Text, out value);
            movementVariables.Axis_c_drop_by = value;

            if (manualButton.Checked == true) display_textbox4_manual();
            if (segmentButton.Checked == true) display_textbox4_segment();
        }

        //Set Axis-c rest position (for special movement)     Note: This feature is not used anymore
        private void button15_Click(object sender, EventArgs e)
        {
            //float value = 0;
            //float.TryParse(textBox5.Text, out value);
            //movementVariables.Axis_c_rest_position = value;

            //if (manualButton.Checked == true) display_textbox4_manual();
            //if (segmentButton.Checked == true) display_textbox4_segment();
        }

        #endregion

        #region "Manual movement specific textbox related controls"
        public delegate bool set_Position(int index, float value);
        private void set_manualVariables(set_Position s)
        {
            float[] positionArray = new float[3] {0, 0, 0};
            coor_string_to_floatArr(textBox3.Text, positionArray);
            s(0, positionArray[0]);
            s(1, positionArray[1]);
            s(2, positionArray[2]);
        }

        //Set start_position:
        private void button7_Click(object sender, EventArgs e)
        {

            set_manualVariables(movementVariables.set_StartPosition);
            display_textbox4_manual();
        }

        //Set end position:
        private void button10_Click(object sender, EventArgs e)
        {
            set_manualVariables(movementVariables.set_EndPosition);
            display_textbox4_manual();
        }

        //Add intermediate position:
        private void button8_Click(object sender, EventArgs e)
        {
            movementVariables.Intermediate_positions.Add(new int[3] { 0, 0, 0 }); // add one more element to prevent overrding (update: 4/2/2020)
            set_manualVariables(movementVariables.set_IntermediatePosition);
            display_textbox4_manual();
        }

        //Reset all (manual) positions:
        private void button9_Click(object sender, EventArgs e)
        {
            unitChangeHandler();
            axisCinputBox.Enabled = true; manualBox.Enabled = true; // enable these 2 interfaces as the above function call disables them
            display_textbox4_manual();
        }
        #endregion
        #endregion

        //Button for start special movement (movement depends on which radio box (manual or segment) is checked):
        private async void button13_Click(object sender, EventArgs e)
        {
            // Disable the Start button and enable the Stop button
            button13.Enabled = false;
            btnStop.Enabled = true;

            // Disable Add and Clear all Segments buttons
            button21.Enabled = false;
            button22.Enabled = false;

            // Create a new CancellationTokenSource
            _cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _cancellationTokenSource.Token;

            #region "agilent setup"
            //Agilent VNA (surfaceScan) code:
            PNA_init();
            #endregion

            try
            {
                // Start the movement in a seperate process
                await Task.Run(() => movementType.move(movementVariables, cancellationToken), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // Handle cancellation (optional)
                printTextBox1("Measurement Stopped");
            }
            finally
            {
                // Re-enable the Start button and disable the Stop button
                button13.Enabled = true;
                btnStop.Enabled = false;

                // Disable Add and Clear all Segments buttons
                button21.Enabled = true;
                button22.Enabled = true;

                // Clean up the CancellationTokenSource
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
            }
            cur_abs_pos(abs_position);
        }
        #region "Others"
        //Return to origin button:
        private void returnOriginButton_Click(object sender, EventArgs e)
        {
            movementType.goHome(movementVariables);
            cur_abs_pos(abs_position);
        }

        //Set as origin button:
        private void originButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrintOutput(textBox1, "Setting origin..", PrintStyle.Normal, true);
                gclib.GCommand("AB;MO;SHA");
                //command to controller to set origin:
                gclib.GCommand("DP0,0,0");
                PrintOutput(textBox1, "done");
                System.Threading.Thread.Sleep(200);
                cur_abs_pos(abs_position);
            }
            catch (Exception ex)
            {
                PrintOutput(textBox1, "ERROR in setting gantry origin: " + ex.Message, PrintStyle.Instruction);
            }
        }

        //Function for event when enter key is pressed, for "unitbox". 
        //registered as eventhandler for unitbox in .designer file
        private void CheckEnter_unitbox(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed. Now do:
                float value = 10; // self determined default value in mm
                float.TryParse(unitbox.Text, out value);
                movementVariables.Increment_unit_a = value;
                movementVariables.Increment_unit_b = value;
                movementVariables.Increment_unit_c = value;
            }
        }
        #endregion

        #endregion // Completed controllers all encompassing region

        #region "Controllers under construction (update: completed)"

        #region "Speed button event handlers:
        //axis-a slew speed button:
        private void button23_Click(object sender, EventArgs e)
        {
            int speed = 20; // self determined default value in mm/S
            if (!(Int32.TryParse(textBox8.Text, out speed)))
            {
                //if conversion failed, revert to default slew speed
                speed = 20;
            }
            movementVariables.Speed_a = speed;
        }

        //axis-b slew speed button:
        private void button24_Click(object sender, EventArgs e)
        {
            int speed = 20; // self determined default value in mm/S
            if (!(Int32.TryParse(textBox8.Text, out speed)))
            {
                //if conversion failed, revert to default slew speed
                speed = 20;
            }
            movementVariables.Speed_b = speed;
        }

        //axis-c slew speed button:
        private void button25_Click(object sender, EventArgs e)
        {
            int speed = 20;
            if (!(Int32.TryParse(textBox8.Text, out speed)))
            {
                //if conversion failed, revert to default slew speed
                speed = 20;
            }
            movementVariables.Speed_c = speed;
        }
        #endregion

        #region "Segment_movement input buttons"

        private void segment_position_insert(int index)
        {
            float value = 0;
            float.TryParse(textBox7.Text, out value);
            movementVariables.set_SegmentPosition(index, value);
            display_textbox4_segment();
        }

        // Segment movement: A (start) button:
        private void btnAStart_Click(object sender, EventArgs e)
        {
            segment_position_insert(0);
        }

        // Segment movement: A (end) button:
        private void button17_Click(object sender, EventArgs e)
        {
            segment_position_insert(1);
        }

        // Segment movement: A (delta) button:
        private void button19_Click(object sender, EventArgs e)
        {
            segment_position_insert(2);
        }

        // Segment movement: B (start) button:
        private void button16_Click(object sender, EventArgs e)
        {
            segment_position_insert(3);
        }

        // Segment movement: B (end) button:
        private void button18_Click(object sender, EventArgs e)
        {
            segment_position_insert(4);
        }

        // Segment movement: B (delta) button:
        private void button20_Click(object sender, EventArgs e)
        {
            segment_position_insert(5);
        }

        // Segment movement: C (start) button:
        private void button27_Click(object sender, EventArgs e)
        {
            segment_position_insert(6);
        }

        // Segment movement: C (end) button:
        private void button28_Click(object sender, EventArgs e)
        {
            segment_position_insert(7);
        }

        // Segment movement: C (delta) button:
        private void button29_Click(object sender, EventArgs e)
        {
            segment_position_insert(8);
        }

        // Segment movement: reset all segments button:
        private void button22_Click(object sender, EventArgs e)
        {
            movementVariables.clear_allSegments(display_textbox4_segment);
        }

        // Segment movement: add segment button:
        private void button21_Click(object sender, EventArgs e)
        {
            movementVariables.add_SegmentGrid(display_textbox4_segment);
        }
        #endregion


        //Configuration of GUI if manual_button is checked:
        private void manualButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manualButton.Checked == true)
            {
                movementVariables.clear_allSegments(display_textbox4_segment); //added to replace unitChangeHandler
                movementType = new ManualMovement(analyzer, this, gclib/*, ref movementVariables*/);
                
                segmentBox.Enabled = false; 
                axisCinputBox.Enabled = true;
                rowOffsetBox.Enabled = false;
                manualBox.Enabled = true;
                textBox4.Clear();
            }
        }

        //Configuration of GUI if segment_button is checked:
        private void segmentButton_CheckedChanged(object sender, EventArgs e)
        {
            if (segmentButton.Checked == true)
            {
                movementVariables.clear_allSegments(display_textbox4_segment); //added to replace unitChangeHandler
                movementType = new SegmentMovement(analyzer, this, gclib/*, ref movementVariables*/);
                
                segmentBox.Enabled = true; 
                axisCinputBox.Enabled = true;
                rowOffsetBox.Enabled = true;
                manualBox.Enabled = false;
                textBox4.Clear();
            }
        }

        #endregion

        #region "Controls + methods currently unused. Feel free to disassociate"

        #region "currently unused"

        //Note to self: currently not working
        public void Main(string address)
        {
            gclib gclib = new gclib();

            try
            {
                //execute any program as dictated by all buttons and given script

                //i plan to change the way we do this abit. i want to establish a connection. check for it
                // then just use this Main function to execute the intention of the comment 2 lines above this

                //calls to gclib should be in a try-catch
                textBox1.AppendText("GVersion: " + gclib.GVersion() + "\n");
                gclib.GOpen(address + " -d"); //Set an appropriate IP address here
                textBox1.AppendText("GInfo: " + gclib.GInfo() + "\n");
                textBox1.AppendText("GCommand: " + gclib.GCommand("MG TIME") + "\n");
            }
            catch (Exception ex)
            {
                textBox1.AppendText("ERROR: " + ex.Message);

            }
            finally
            {
                gclib.GClose(); //Don't forget to close!
            }

        }
        #endregion

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void unitbox_TextChanged(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GeneralGroup_Enter(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        // Section: calibration settings

        // Axis-c Calibration Set button:
        private void button14_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(unitCalibrateTextBox.Text, out value);
            myMmToStepper_unitAxisC = value;
            movementVariables.mmToStepper_unitAxisC = value;
        }

        // Axis-a + Axis-b Calibration Set button:
        private void button26_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(unitCalibrateTextBox.Text, out value);
            myMmToStepper_unitAxisAB = value;
            movementVariables.mmToStepper_unitAxisAB = value;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Cancel current measurment
            _cancellationTokenSource?.Cancel();
            // Stop motor movement imedately
            //movementType.stopMovement(movementVariables); not used because does not work as intended, it only stops the current axis-move.
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartupConfig_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        // write the inputed even row offset to the movementVariables instance
        private void button12_Click(object sender, EventArgs e)
        {
            float value = 0;
            float.TryParse(textBox9.Text, out value);
            movementVariables.Even_row_offset = value;
            display_textbox4_segment();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void translatorTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
