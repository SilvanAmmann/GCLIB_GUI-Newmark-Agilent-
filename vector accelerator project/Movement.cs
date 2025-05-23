﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
[assembly: InternalsVisibleTo("MovementTests")]


namespace vector_accelerator_project
{
    class MovementVariables
    {
        //Variables that store coordinates: 
        public virtual int[] Start_position { get; private set; }
        public virtual int[] End_position { get; private set; }
        //a list of integer arrays, each with 2 elements:
        public virtual List<int[]> Intermediate_positions { get; private set; }

        // Used for Segment Movement:
        // each int[] has 6 elements (in-order): 
        // a(start), a(end), a(delta), b(start), b(end), b(delta)
        public List<int[]> Segment_positions { get; private set; }

        // varible to tell if it is an AB-axis movement (drop C-axis available) or not
        public virtual bool ABaxis { get; set; }

        //Variables that store other parameters:
        public virtual float Axis_c_drop_by { get; set; }  //axis-c drop by how many units while sampling

        public virtual float Even_row_offset { get; set; }

        public virtual float Increment_unit_a { get; set; }
        public virtual float Increment_unit_b { get; set; }
        public virtual float Increment_unit_c { get; set; }
        public virtual int Speed_a { get; set; } //recommended speed
        public virtual int Speed_b { get; set; } //recommended speed
        public virtual int Speed_c { get; set; } //recommended speed


        // Calibration Units (stepper units per mm (assert Integer type)):
        public virtual int mmToStepper_unitAxisC { get; set; }
        public virtual int mmToStepper_unitAxisAB { get; set; }

        public MovementVariables()
        {
            //Variables that store coordinates:
            Start_position = new int[3] {0, 0, 0};
            End_position = new int[3] {0, 0, 0};
            //a list of integer arrays, each with 2 elements:
            Intermediate_positions = new List<int[]>();

            Segment_positions = new List<int[]>();
            Segment_positions.Add(new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0}); // Will be filled with the segment/grid parameters.

            ABaxis = true;

            //Variables that store other parameters:
            Axis_c_drop_by = 0;  //axis-c drop by how many units while sampling
            Even_row_offset = 0;


            // UPDATE ON UNITS: 2000 => 8mm , 20000 => 80mm
            // Set as DEFAULT. 
            // Override option possible.
            mmToStepper_unitAxisC = 25000;
            mmToStepper_unitAxisAB = 250;
        }

        public virtual bool set_StartPosition(int index, float value) { return true; }
        public virtual bool set_EndPosition(int index, float value) { return true; }
        public virtual bool set_IntermediatePosition(int index, float value) { return true; }
        public virtual bool set_SegmentPosition(int index, float value) { return true; }

        public delegate void displayFunc();

        #region unused
        // This function is not used in newer versions because everything is done with the add_SegmentGrid() funciton
        public bool add_Segment(displayFunc display)
        {
            // check if Segment values are valid (i.e. if they add up):
            bool same_num_samples = false;
            int b_sample_num = (Math.Abs(Segment_positions.Last()[5]) > 0) ? (Segment_positions.Last()[4] - Segment_positions.Last()[3]) / Segment_positions.Last()[5] : 0;
            int a_sample_num = (Math.Abs(Segment_positions.Last()[2]) > 0) ? (Segment_positions.Last()[1] - Segment_positions.Last()[0]) / Segment_positions.Last()[2] : 0;
            same_num_samples = (b_sample_num == 0 || a_sample_num == 0 || (b_sample_num != a_sample_num)) ? false : true;
            if (same_num_samples && ((Segment_positions.Last()[1] - Segment_positions.Last()[0]) % Segment_positions.Last()[2] == 0) && ((Segment_positions.Last()[4] - Segment_positions.Last()[3]) % Segment_positions.Last()[5] == 0))
            {
                Segment_positions.Add(new int[6] { 0, 0, 0, 0, 0, 0 });
                display?.Invoke();
                return true;
            }
            else if(b_sample_num != 0 || a_sample_num != 0)
            {
                // edge case: if either a or b direction is stationary, but not both
                if(b_sample_num != 0)
                {
                    if (((Segment_positions.Last()[4] - Segment_positions.Last()[3]) % Segment_positions.Last()[5] == 0))
                    {
                        Segment_positions.Add(new int[9] {0, 0, 0, 0, 0, 0, 0, 0, 0});
                        display?.Invoke();
                        return true;
                    }
                }
                else if(a_sample_num != 0)
                {
                    if(((Segment_positions.Last()[1] - Segment_positions.Last()[0]) % Segment_positions.Last()[2] == 0))
                    {
                        Segment_positions.Add(new int[6] { 0, 0, 0, 0, 0, 0 });
                        display?.Invoke();
                        return true;
                    }
                }
            }
            // if has not return, it is false
                System.Windows.Forms.MessageBox.Show("Segment values do not add up. Check your input values.", "Invalid Input.");
                return false;
        }
        #endregion

        public bool add_SegmentGrid(displayFunc display)
        {
            // Note: y = a axis in GUI
            // Note: x = b axis in GUI
            // Note: z = c axis in GUI
            // Note: -a = move forward
            // Note: -b = move right
            // Note: -c = move up
            int anchorStart_y = Segment_positions.Last()[0];
            int anchorStart_x = Segment_positions.Last()[3];
            int anchorStart_z = Segment_positions.Last()[6];

            int anchorEnd_y = Segment_positions.Last()[1];
            int anchorEnd_x = Segment_positions.Last()[4];
            int anchorEnd_z = Segment_positions.Last()[7];

            int increment_y = Math.Abs(Segment_positions.Last()[2]);
            int increment_x = Math.Abs(Segment_positions.Last()[5]);
            int increment_z = Math.Abs(Segment_positions.Last()[8]);

            int direction_y = Math.Sign(anchorEnd_y - anchorStart_y);
            int direction_x = Math.Sign(anchorEnd_x - anchorStart_x);
            int direction_z = Math.Sign(anchorEnd_z - anchorStart_z);

            // We iterate through y_axis end to end, then move increment x_axis once, then repeat, then increment z once, then repeat:

            //check alignment: increment multiple is valid. Check that not all increments are zero
            bool validIncrement_x = (direction_x != 0 && increment_x > 0) ? (anchorEnd_x - anchorStart_x) % increment_x == 0 ? true : false : false;
            bool validIncrement_y = (direction_y != 0 && increment_y > 0) ? (anchorEnd_y - anchorStart_y) % increment_y == 0 ? true : false : false;
            bool validIncrement_z = (direction_z != 0 && increment_z > 0) ? (anchorEnd_z - anchorStart_z) % increment_z == 0 ? true : false : false;
            validIncrement_x = (direction_x == 0 & increment_x == 0) ? true : validIncrement_x;
            validIncrement_y = (direction_y == 0 & increment_y == 0) ? true : validIncrement_y;
            validIncrement_z = (direction_z == 0 & increment_z == 0) ? true : validIncrement_z;
            bool allDeltaZero = (increment_x == 0 & increment_y ==0 & increment_z == 0) ? true : false;

            if (!validIncrement_x || !validIncrement_y || !validIncrement_z || allDeltaZero)
            {
                System.Windows.Forms.MessageBox.Show("Segment values do not add up. Check your input values.", "Invalid Input.");
                return false;
            }

            // Start inserting segments into array:
            int i = anchorStart_z;
            do
            {
                int y_index = 0;
                int j = anchorStart_y;
                do
                {
                    // set y-axis parameter
                    Segment_positions.Last()[0] = j;
                    Segment_positions.Last()[1] = j;
                    Segment_positions.Last()[2] = 0;

                    // set x-axis parameter
                    if (y_index % 2 == 0)
                    {
                        Segment_positions.Last()[3] = anchorStart_x;
                        Segment_positions.Last()[4] = anchorEnd_x;
                    }
                    else
                    {
                        Segment_positions.Last()[3] = anchorStart_x + (int)Math.Round(Even_row_offset);
                        Segment_positions.Last()[4] = anchorEnd_x + (int)Math.Round(Even_row_offset);
                    }
                    Segment_positions.Last()[5] = direction_x * increment_x;

                    // set z-axis parameter
                    Segment_positions.Last()[6] = i;
                    Segment_positions.Last()[7] = i;
                    Segment_positions.Last()[8] = 0;

                    Segment_positions.Add(new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });

                    if (increment_y == 0) break;
                    y_index += 1;
                    j += direction_y * increment_y;
                } while (j != anchorEnd_y + direction_y * increment_y);

                if (increment_z == 0) break;
                i += direction_z * increment_z;
            } while (i != anchorEnd_z + direction_z * increment_z);

            // set AB-axis mode with drop C-axis to true or false
            if (increment_z != 0) 
            {
                ABaxis = false;
            }
            else 
            {
                ABaxis = true;
            }

            display?.Invoke();

            return true;
        }

        public void clear_allSegments(displayFunc display)
        {
            Segment_positions.Clear(); // Remove all elements
            Segment_positions.Add(new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }); // Add a new default array

            // Set all C-axis and hexagonal grid offsets to zero.
            Axis_c_drop_by = 0;
            Even_row_offset = 0;

            display?.Invoke();
        }
    }

    class MovementVariables_stepperUnit : MovementVariables
    {
        public MovementVariables_stepperUnit()
            : base()
        {
            Increment_unit_a = 10000;
            Increment_unit_b = 10000;
            Increment_unit_c = 500000;
            Speed_a = 10000; //maximum speed < 25000 stepper units/s
            Speed_b = 10000; //maximum speed < 25000 stepper units/s
            Speed_c = 500000; //maximum speed < 500000 stepper units/s
        }

        public override bool set_StartPosition(int index, float value)
        {
            try
            {
                Start_position[index] = (int)Math.Round(value);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

        public override bool set_EndPosition(int index, float value)
        {
            try
            {
                End_position[index] = (int)Math.Round(value);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

        public override bool set_IntermediatePosition(int index, float value)
        {
            try
            {
                Intermediate_positions.Last()[index] = (int)Math.Round(value);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

        public override bool set_SegmentPosition(int index, float value)
        {
            try
            {
                Segment_positions.Last()[index] = (int)Math.Round(value);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

    }

    class MovementVariables_mmUnit : MovementVariables
    {
        public MovementVariables_mmUnit()
            : base()
        {
            Increment_unit_a = 40;
            Increment_unit_b = 40;
            Increment_unit_c = 40;
            Speed_a = 40; //recommended speed 40 mm/s
            Speed_b = 40; //recommended speed 40 mm/s
            Speed_c = 20; //recommended speed 20 mm/s
        }

        // Provate variables that store other parameters:
        private float axis_c_drop_by;
        private float axis_c_rest_position;
        private float even_row_offset;
        private float increment_unit_a;
        private float increment_unit_b;
        private float increment_unit_c;
        private int speed_a;
        private int speed_b;
        private int speed_c;

        public override float Axis_c_drop_by
        {
            get => axis_c_drop_by;
            set => axis_c_drop_by = value * mmToStepper_unitAxisC;
        }  

        public override float Even_row_offset
        {
            get => even_row_offset;
            set => even_row_offset = value * mmToStepper_unitAxisAB;
        }

        public override float Increment_unit_a
        {
            get => increment_unit_a;
            set => increment_unit_a = value * mmToStepper_unitAxisAB;
        }

        public override float Increment_unit_b
        {
            get => increment_unit_b;
            set => increment_unit_b = value * mmToStepper_unitAxisAB;
        }
        public override float Increment_unit_c
        {
            get => increment_unit_c;
            set => increment_unit_c = value * mmToStepper_unitAxisC;
        }

        public override int Speed_a
        {
            get => speed_a;
            set => speed_a = value * mmToStepper_unitAxisAB;
        }

        public override int Speed_b
        {
            get => speed_b;
            set => speed_b = value * mmToStepper_unitAxisAB;
        }

        public override int Speed_c
        {
            get => speed_c;
            set => speed_c = value * mmToStepper_unitAxisC;
        }

        public override bool set_StartPosition(int index, float value)
        {
            try
            {
                if (index < 2)
                {
                    Start_position[index] = (int)Math.Round(value * mmToStepper_unitAxisAB);
                }
                else
                {
                    Start_position[index] = (int)Math.Round(value * mmToStepper_unitAxisC);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

        public override bool set_EndPosition(int index, float value)
        {
            try
            {
                if (index < 2)
                {
                    End_position[index] = (int)Math.Round(value * mmToStepper_unitAxisAB);
                }
                else
                {
                    End_position[index] = (int)Math.Round(value * mmToStepper_unitAxisC);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

        public override bool set_IntermediatePosition(int index, float value)
        {
            try
            {
                if (index < 2)
                {
                    Intermediate_positions.Last()[index] = (int)Math.Round(value * mmToStepper_unitAxisAB);
                }
                else
                {
                    Intermediate_positions.Last()[index] = (int)Math.Round(value * mmToStepper_unitAxisC);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }

        public override bool set_SegmentPosition(int index, float value)
        {
            try
            {
                if (index < 6)
                {
                    Segment_positions.Last()[index] = (int)Math.Round(value * mmToStepper_unitAxisAB);
                }
                else
                {
                    Segment_positions.Last()[index] = (int)Math.Round(value * mmToStepper_unitAxisC);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic exception handler: {e}");
                return false;
            }
            return true;
        }


    }

    // Not to be exposed to other modules. (clean code purposes)
    // Use higher level wrappers listed below instead
    class MoveFactory
    {
        private Form1 form;
        private gclib gclib;
        private string retCode;

        public MoveFactory(Form1 form, gclib gclib)
        {
            this.form = form;
            this.gclib = gclib;
        }

        //Basic PA (absolute coordinates) movement:
        protected internal void runAbsoluteMoveCommand(string axis, int distance_units, int speed)
        {
            try
            {
                gclib.GCommand("MO;SH" + axis);
                gclib.GCommand("PA" + axis + "=" + distance_units);
                gclib.GCommand("SP" + axis + "=" + speed);
                gclib.GCommand("BG" + axis);
                gclib.GMotionComplete(axis);
            }
            catch (Exception ex)
            {
                form.printTextBox1("ERROR in runAbsoluteMoveCommand on axis " + axis + ": " + ex.Message, Form1.PrintStyle.Instruction);
            }
        }
        //Simple PR (relative distances) movement:
        public void runRelativeMoveCommand(string axis, float distance_units, int speed)
        {
            try
            {
                gclib.GCommand("MO;SH" + axis);
                gclib.GCommand("PR" + axis + "=" + (Int32)Math.Round(distance_units));
                gclib.GCommand("SP" + axis + "=" + speed);
                gclib.GCommand("BG" + axis);
                gclib.GMotionComplete(axis);
                
            }
            catch (Exception ex)
            {
                form.printTextBox1("ERROR in runRelativeMoveCommand on axis " + axis + ": " + ex.Message, Form1.PrintStyle.Instruction);
            }
        }

        //Movement for any kind of absolute movment in the ABC-axis space (without C-axis bar drop):
        protected internal void general_move_helper(int[] position, MovementVariables movementVariables)
        {
            runAbsoluteMoveCommand("A", position[0], movementVariables.Speed_a);
            runAbsoluteMoveCommand("B", position[1], movementVariables.Speed_b);
            runAbsoluteMoveCommand("C", position[2], movementVariables.Speed_c);
        }

        //Movement for a specific set of AB-axis coordinates within MovementVariables, with C-axis bar drop:
        protected internal void special_move_helper(int[] position, MovementVariables movementVariables)
        {
            int dropped_abs_position = (int)Math.Round(position[2] + movementVariables.Axis_c_drop_by);
            runAbsoluteMoveCommand("C", position[2], movementVariables.Speed_c);
            runAbsoluteMoveCommand("A", position[0], movementVariables.Speed_a);
            runAbsoluteMoveCommand("B", position[1], movementVariables.Speed_b);
            runAbsoluteMoveCommand("C", dropped_abs_position, movementVariables.Speed_c);
        }


        // Return to Origin
        public void goHome(MovementVariables movementVariables)
        {
            runAbsoluteMoveCommand("A", 0, movementVariables.Speed_a);
            runAbsoluteMoveCommand("B", 0, movementVariables.Speed_b);
            runAbsoluteMoveCommand("C", 0, movementVariables.Speed_c);
        }

        // Stop current Movement, Note: Not used, does not work as intended
        public void stopMovement(MovementVariables movementVariables)
        {
            gclib.GCommand("ST");
        }
    }

    // Currently supports both manual and segmented movement:
    class MovementType
    {
        //protected MovementVariables movementVariables;
        protected PNA analyzer;
        protected MoveFactory moveFactory;
        protected Form1_EventListeners form1_EventListeners;
        
        public MovementType(PNA analyzer, Form1 form, gclib gclib /*ref MovementVariables movementVariables*/)
        {
            //this.movementVariables = movementVariables;
            this.analyzer = analyzer;
            this.moveFactory = new MoveFactory(form, gclib);
            this.form1_EventListeners = new Form1_EventListeners(form);
            //this.gclib = gclib;
        }

        public virtual void move(MovementVariables movementVariables, CancellationToken cancellationToken) { }

        public void goHome(MovementVariables movementVariables)
        {
            moveFactory.goHome(movementVariables);
        }

        public void runRelativeMoveCommand(string axis, float distance_units, int speed)
        {
            moveFactory.runRelativeMoveCommand(axis, distance_units, speed);
        }

        // Not used because does not work as desired
        public void stopMovement(MovementVariables movementVariables)
        {
            moveFactory.stopMovement(movementVariables);
        }
    }
    
    class ManualMovement : MovementType
    {
        public ManualMovement(PNA analyzer, Form1 form, gclib gclib/* ref MovementVariables movementVariables*/)
            : base(analyzer, form, gclib/* ref movementVariables*/)
        {
        }

        override
        public void move(MovementVariables movementVariables, CancellationToken cancellationToken)
        {
            moveFactory.special_move_helper(movementVariables.Start_position, movementVariables);

            analyzer.PNA_scan(movementVariables.Start_position, movementVariables);
            System.Threading.Thread.Sleep(200);

            movementVariables.Intermediate_positions?.ForEach(a => {

                // Check for cancellation at the start of each segment
                if (cancellationToken.IsCancellationRequested)
                {
                    return; // Exit the ForEach loop and stop the entire function
                }

                // move to next point
                moveFactory.special_move_helper(a, movementVariables);
                // wait 200ms
                System.Threading.Thread.Sleep(200);
                // make VNA scan
                analyzer.PNA_scan(a, movementVariables);
            });

            moveFactory.special_move_helper(movementVariables.End_position, movementVariables);
            System.Threading.Thread.Sleep(200);

            analyzer.PNA_scan(movementVariables.End_position, movementVariables);
        }
    }

    class SegmentMovement : MovementType
    {
        private Form1 form; // for test purposes: to print stopwatch time

        public SegmentMovement(PNA analyzer, Form1 form, gclib gclib/*, ref MovementVariables movementVariables*/)
            : base(analyzer, form, gclib/*, ref movementVariables*/)
        {
            this.form = form; // for test purposes: to print stopwatch time
        }

        override
        public void move(MovementVariables movementVariables, CancellationToken cancellationToken)
        {
            int counter = 0; // indicates how many segments have been processed.
            var timer = System.Diagnostics.Stopwatch.StartNew();
            movementVariables.Segment_positions?.ForEach(a =>
            {
                // Check for cancellation at the start of each segment
                if (cancellationToken.IsCancellationRequested)
                {
                    return; // Exit the ForEach loop and stop the entire function
                }

                int multiplier = 0;
                // Do not consider last element of segment_positions as it does not contain validated input that has passed through the function button21_clicked:
                if (counter < movementVariables.Segment_positions.Count - 1)
                {
                    while (true)
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            // Exit the loop if cancellation is requested
                            return;
                        }

                        // Reuse Start_position array to place each of our segment movement coordinates
                        movementVariables.Start_position[0] = a[0];
                        movementVariables.Start_position[1] = multiplier * a[5] + a[3];
                        movementVariables.Start_position[2] = a[6];
                        multiplier += 1;

                        // move gantry
                        if (movementVariables.ABaxis == true)
                        {
                            moveFactory.special_move_helper(movementVariables.Start_position, movementVariables);
                        }
                        else
                        {
                            moveFactory.general_move_helper(movementVariables.Start_position, movementVariables);
                        }

                        // VNA measurement
                        analyzer.PNA_scan(movementVariables.Start_position, movementVariables);

                        if (movementVariables.Start_position[0] == a[1] && movementVariables.Start_position[1] == a[4]) break;                      
                    }
                    counter += 1;
                }
            });
            if (movementVariables.ABaxis == true)
            {
                // return to original axis-c rest position before ending movement:
                moveFactory.runAbsoluteMoveCommand("C", movementVariables.Segment_positions[movementVariables.Segment_positions.Count - 2][7], movementVariables.Speed_c);
            }
            form.printTextBox1($"Grid measurement took: {timer.ElapsedMilliseconds / 1000}s\n");
        }

    }

    #region "Classes currently ununsed"
    // Not needed. Left in case
    public class Movement
    {
        public Movement()
        {

        }
    }


    class Form1_EventListeners
    {
        private Form1 form;

        public Form1_EventListeners(Form1 form)
        {
            this.form = form;
        }

        internal Boolean mmButton_checked()
        {
            return form.mmButton_checked();
        }

        //internal void clearMovementValueDisplay()
        //{
        //     form.clearMovementValue_textBox();
        // }

    }
    #endregion
}
