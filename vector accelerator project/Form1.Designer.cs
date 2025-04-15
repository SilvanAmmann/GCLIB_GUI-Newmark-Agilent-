using System.Windows.Forms;
//using System.Windows.Controls;

namespace vector_accelerator_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.GClibBackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DisconnectStripButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddressTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.GeneralGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unitbox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.originButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.translatorTabPage = new System.Windows.Forms.TabPage();
            this.segmentBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.segmentNormalButton = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.btnAStart = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.manualBox = new System.Windows.Forms.GroupBox();
            this.axisCinputBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.PNAtabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPNA = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownAvg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStop = new System.Windows.Forms.NumericUpDown();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.labelMeasure = new System.Windows.Forms.Label();
            this.comboBoxMeasure = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.SelectCST = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDownIFBW = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.segmentButton = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.returnOriginButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.configBox = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.StartupConfig = new System.Windows.Forms.TabPage();
            this.button25 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.stepperButton = new System.Windows.Forms.RadioButton();
            this.button23 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.mmButton = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.unitCalibrateTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.segmentGridButton = new System.Windows.Forms.RadioButton();
            this.MainToolStrip.SuspendLayout();
            this.GeneralGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.translatorTabPage.SuspendLayout();
            this.segmentBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.manualBox.SuspendLayout();
            this.axisCinputBox.SuspendLayout();
            this.PNAtabPage.SuspendLayout();
            this.tableLayoutPanelPNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIFBW)).BeginInit();
            this.configBox.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.StartupConfig.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(11, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(555, 158);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "System Output";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Special Movement";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Absolute Position Display";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 246);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(259, 586);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // GClibBackgroundWorker1
            // 
            this.GClibBackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GClibBackgroundWorker1_DoWork);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.DisconnectStripButton,
            this.ConnectStripButton,
            this.AddressTextBox,
            this.toolStripButton3});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(824, 31);
            this.MainToolStrip.TabIndex = 15;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(137, 28);
            this.toolStripButton1.Text = "Save PNA Data";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(138, 28);
            this.toolStripButton2.Text = "Clear PNA data";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(125, 28);
            this.toolStripLabel1.Text = "GOpen() Address:";
            // 
            // DisconnectStripButton
            // 
            this.DisconnectStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DisconnectStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DisconnectStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DisconnectStripButton.Image")));
            this.DisconnectStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisconnectStripButton.Name = "DisconnectStripButton";
            this.DisconnectStripButton.Size = new System.Drawing.Size(86, 28);
            this.DisconnectStripButton.Text = "Disconnect";
            this.DisconnectStripButton.Click += new System.EventHandler(this.DisconnectStripButton_Click);
            // 
            // ConnectStripButton
            // 
            this.ConnectStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ConnectStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectStripButton.Name = "ConnectStripButton";
            this.ConnectStripButton.Size = new System.Drawing.Size(67, 28);
            this.ConnectStripButton.Text = "Connect";
            this.ConnectStripButton.Click += new System.EventHandler(this.ConnectStripButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(227, 31);
            this.AddressTextBox.Text = "192.168.1.1";
            this.AddressTextBox.Click += new System.EventHandler(this.AddressTextBox_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // GeneralGroup
            // 
            this.GeneralGroup.Controls.Add(this.label5);
            this.GeneralGroup.Controls.Add(this.unitbox);
            this.GeneralGroup.Controls.Add(this.button5);
            this.GeneralGroup.Controls.Add(this.label4);
            this.GeneralGroup.Controls.Add(this.button6);
            this.GeneralGroup.Controls.Add(this.button3);
            this.GeneralGroup.Controls.Add(this.label3);
            this.GeneralGroup.Controls.Add(this.button4);
            this.GeneralGroup.Controls.Add(this.button2);
            this.GeneralGroup.Controls.Add(this.label1);
            this.GeneralGroup.Controls.Add(this.button1);
            this.GeneralGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralGroup.Location = new System.Drawing.Point(569, 47);
            this.GeneralGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GeneralGroup.Name = "GeneralGroup";
            this.GeneralGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GeneralGroup.Size = new System.Drawing.Size(412, 178);
            this.GeneralGroup.TabIndex = 16;
            this.GeneralGroup.TabStop = false;
            this.GeneralGroup.Text = "General Relative Movement";
            this.GeneralGroup.Enter += new System.EventHandler(this.GeneralGroup_Enter);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(295, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 54);
            this.label5.TabIndex = 20;
            this.label5.Text = "Distance in\r\nStepper Units (>300):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // unitbox
            // 
            this.unitbox.Location = new System.Drawing.Point(303, 96);
            this.unitbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitbox.Name = "unitbox";
            this.unitbox.Size = new System.Drawing.Size(89, 23);
            this.unitbox.TabIndex = 17;
            this.unitbox.TextChanged += new System.EventHandler(this.unitbox_TextChanged);
            this.unitbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter_unitbox);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(196, 129);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 31);
            this.button5.TabIndex = 19;
            this.button5.Text = "- (c-axis)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "c-axis";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 129);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 31);
            this.button6.TabIndex = 17;
            this.button6.Text = "+ (c-axis)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 31);
            this.button3.TabIndex = 16;
            this.button3.Text = "- (b-axis)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "b-axis";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 78);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 31);
            this.button4.TabIndex = 14;
            this.button4.Text = "+ (b-axis)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "- (a-axis)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "a-axis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "+ (a-axis)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // originButton
            // 
            this.originButton.Location = new System.Drawing.Point(1177, 4);
            this.originButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.originButton.Name = "originButton";
            this.originButton.Size = new System.Drawing.Size(111, 27);
            this.originButton.TabIndex = 17;
            this.originButton.Text = "Set as Origin";
            this.originButton.UseVisualStyleBackColor = true;
            this.originButton.Click += new System.EventHandler(this.originButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 58);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Set Start point";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 87);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 27);
            this.button8.TabIndex = 19;
            this.button8.Text = "Set Intermediate point (multiple)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(176, 87);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(183, 27);
            this.button9.TabIndex = 20;
            this.button9.Text = "Reset all points";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(125, 58);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "Set End point";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 22);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Point Input (format \"A, B\"):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.manualButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.segmentButton);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(284, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(892, 609);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anchor coordinates";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(213, 550);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(171, 46);
            this.btnStop.TabIndex = 51;
            this.btnStop.Text = "Stop Movement";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.translatorTabPage);
            this.tabControl1.Controls.Add(this.PNAtabPage);
            this.tabControl1.Location = new System.Drawing.Point(21, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 505);
            this.tabControl1.TabIndex = 44;
            // 
            // translatorTabPage
            // 
            this.translatorTabPage.Controls.Add(this.groupBox2);
            this.translatorTabPage.Controls.Add(this.segmentBox);
            this.translatorTabPage.Controls.Add(this.manualBox);
            this.translatorTabPage.Controls.Add(this.axisCinputBox);
            this.translatorTabPage.Controls.Add(this.label14);
            this.translatorTabPage.Controls.Add(this.label15);
            this.translatorTabPage.Controls.Add(this.label19);
            this.translatorTabPage.Location = new System.Drawing.Point(4, 25);
            this.translatorTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translatorTabPage.Name = "translatorTabPage";
            this.translatorTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translatorTabPage.Size = new System.Drawing.Size(381, 476);
            this.translatorTabPage.TabIndex = 0;
            this.translatorTabPage.Text = "Translator";
            this.translatorTabPage.UseVisualStyleBackColor = true;
            // 
            // segmentBox
            // 
            this.segmentBox.Controls.Add(this.button29);
            this.segmentBox.Controls.Add(this.button28);
            this.segmentBox.Controls.Add(this.button27);
            this.segmentBox.Controls.Add(this.segmentGridButton);
            this.segmentBox.Controls.Add(this.segmentNormalButton);
            this.segmentBox.Controls.Add(this.label18);
            this.segmentBox.Controls.Add(this.textBox7);
            this.segmentBox.Controls.Add(this.button18);
            this.segmentBox.Controls.Add(this.button17);
            this.segmentBox.Controls.Add(this.button22);
            this.segmentBox.Controls.Add(this.button16);
            this.segmentBox.Controls.Add(this.button21);
            this.segmentBox.Controls.Add(this.btnAStart);
            this.segmentBox.Controls.Add(this.button19);
            this.segmentBox.Controls.Add(this.button20);
            this.segmentBox.Location = new System.Drawing.Point(11, 275);
            this.segmentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.segmentBox.Name = "segmentBox";
            this.segmentBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.segmentBox.Size = new System.Drawing.Size(361, 203);
            this.segmentBox.TabIndex = 52;
            this.segmentBox.TabStop = false;
            this.segmentBox.Text = "Input by segment:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Location = new System.Drawing.Point(8, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 33);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(282, 8);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 23);
            this.button12.TabIndex = 57;
            this.button12.Text = "Set";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Offset Even Rows (format \"Z\"):";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(196, 9);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(80, 22);
            this.textBox9.TabIndex = 55;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(233, 129);
            this.button29.Margin = new System.Windows.Forms.Padding(4);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(108, 27);
            this.button29.TabIndex = 53;
            this.button29.Text = "C (delta)";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(124, 129);
            this.button28.Margin = new System.Windows.Forms.Padding(4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(108, 27);
            this.button28.TabIndex = 52;
            this.button28.Text = "C (end)";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(16, 129);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(108, 27);
            this.button27.TabIndex = 51;
            this.button27.Text = "C (start)";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // segmentNormalButton
            // 
            this.segmentNormalButton.AutoSize = true;
            this.segmentNormalButton.Checked = true;
            this.segmentNormalButton.Location = new System.Drawing.Point(27, 27);
            this.segmentNormalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.segmentNormalButton.Name = "segmentNormalButton";
            this.segmentNormalButton.Size = new System.Drawing.Size(72, 20);
            this.segmentNormalButton.TabIndex = 49;
            this.segmentNormalButton.TabStop = true;
            this.segmentNormalButton.Text = "Normal";
            this.segmentNormalButton.UseVisualStyleBackColor = true;
            this.segmentNormalButton.CheckedChanged += new System.EventHandler(this.segmentNormalButton_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "Point Input (format \"Z\"):";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(177, 52);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(147, 22);
            this.textBox7.TabIndex = 39;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(124, 102);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(108, 27);
            this.button18.TabIndex = 43;
            this.button18.Text = "B (end)";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(124, 78);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(108, 26);
            this.button17.TabIndex = 44;
            this.button17.Text = "A (end)";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(177, 162);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(143, 27);
            this.button22.TabIndex = 48;
            this.button22.Text = "Clear all segments";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(16, 102);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 27);
            this.button16.TabIndex = 42;
            this.button16.Text = "B (start)";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(41, 162);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(108, 27);
            this.button21.TabIndex = 47;
            this.button21.Text = "Add Segment";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // btnAStart
            // 
            this.btnAStart.Location = new System.Drawing.Point(16, 78);
            this.btnAStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAStart.Name = "btnAStart";
            this.btnAStart.Size = new System.Drawing.Size(108, 26);
            this.btnAStart.TabIndex = 41;
            this.btnAStart.Text = "A (start)";
            this.btnAStart.UseVisualStyleBackColor = true;
            this.btnAStart.Click += new System.EventHandler(this.btnAStart_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(233, 78);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(108, 26);
            this.button19.TabIndex = 46;
            this.button19.Text = "A (delta)";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(233, 102);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(108, 27);
            this.button20.TabIndex = 45;
            this.button20.Text = "B (delta)";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // manualBox
            // 
            this.manualBox.Controls.Add(this.button9);
            this.manualBox.Controls.Add(this.button10);
            this.manualBox.Controls.Add(this.button8);
            this.manualBox.Controls.Add(this.textBox3);
            this.manualBox.Controls.Add(this.button7);
            this.manualBox.Controls.Add(this.label8);
            this.manualBox.Location = new System.Drawing.Point(8, 10);
            this.manualBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualBox.Name = "manualBox";
            this.manualBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualBox.Size = new System.Drawing.Size(364, 119);
            this.manualBox.TabIndex = 43;
            this.manualBox.TabStop = false;
            this.manualBox.Text = "Manual Input:";
            // 
            // axisCinputBox
            // 
            this.axisCinputBox.Controls.Add(this.label10);
            this.axisCinputBox.Controls.Add(this.textBox5);
            this.axisCinputBox.Controls.Add(this.button11);
            this.axisCinputBox.Controls.Add(this.button15);
            this.axisCinputBox.Location = new System.Drawing.Point(3, 143);
            this.axisCinputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axisCinputBox.Name = "axisCinputBox";
            this.axisCinputBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axisCinputBox.Size = new System.Drawing.Size(369, 87);
            this.axisCinputBox.TabIndex = 51;
            this.axisCinputBox.TabStop = false;
            this.axisCinputBox.Text = "Axis-c input:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Other parameter input (format: \"Z\"):";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(244, 20);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 22);
            this.textBox5.TabIndex = 27;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(8, 47);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(145, 38);
            this.button11.TabIndex = 28;
            this.button11.Text = "Axis-c drop bar by:";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(172, 47);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(173, 39);
            this.button15.TabIndex = 31;
            this.button15.Text = "Set Axis-c resting position:";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(8, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(347, 1);
            this.label14.TabIndex = 35;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(8, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(347, 1);
            this.label15.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(8, 233);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(347, 1);
            this.label19.TabIndex = 49;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // PNAtabPage
            // 
            this.PNAtabPage.Controls.Add(this.tableLayoutPanelPNA);
            this.PNAtabPage.Location = new System.Drawing.Point(4, 25);
            this.PNAtabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNAtabPage.Name = "PNAtabPage";
            this.PNAtabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNAtabPage.Size = new System.Drawing.Size(381, 476);
            this.PNAtabPage.TabIndex = 1;
            this.PNAtabPage.Text = "PNA";
            this.PNAtabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPNA
            // 
            this.tableLayoutPanelPNA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPNA.AutoSize = true;
            this.tableLayoutPanelPNA.ColumnCount = 2;
            this.tableLayoutPanelPNA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.6396F));
            this.tableLayoutPanelPNA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.3604F));
            this.tableLayoutPanelPNA.Controls.Add(this.numericUpDownAvg, 1, 8);
            this.tableLayoutPanelPNA.Controls.Add(this.numericUpDownStop, 1, 1);
            this.tableLayoutPanelPNA.Controls.Add(this.labelStart, 0, 0);
            this.tableLayoutPanelPNA.Controls.Add(this.labelStop, 0, 1);
            this.tableLayoutPanelPNA.Controls.Add(this.labelPoints, 0, 2);
            this.tableLayoutPanelPNA.Controls.Add(this.numericUpDownStart, 1, 0);
            this.tableLayoutPanelPNA.Controls.Add(this.labelMeasure, 0, 4);
            this.tableLayoutPanelPNA.Controls.Add(this.comboBoxMeasure, 1, 4);
            this.tableLayoutPanelPNA.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanelPNA.Controls.Add(this.comboBoxFormat, 1, 5);
            this.tableLayoutPanelPNA.Controls.Add(this.numericUpDownPoints, 1, 2);
            this.tableLayoutPanelPNA.Controls.Add(this.SelectCST, 1, 6);
            this.tableLayoutPanelPNA.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanelPNA.Controls.Add(this.label22, 0, 9);
            this.tableLayoutPanelPNA.Controls.Add(this.numericUpDownIFBW, 1, 9);
            this.tableLayoutPanelPNA.Controls.Add(this.label23, 0, 8);
            this.tableLayoutPanelPNA.Location = new System.Drawing.Point(11, 17);
            this.tableLayoutPanelPNA.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelPNA.Name = "tableLayoutPanelPNA";
            this.tableLayoutPanelPNA.RowCount = 11;
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelPNA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelPNA.Size = new System.Drawing.Size(326, 340);
            this.tableLayoutPanelPNA.TabIndex = 51;
            // 
            // numericUpDownAvg
            // 
            this.numericUpDownAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAvg.Location = new System.Drawing.Point(143, 233);
            this.numericUpDownAvg.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAvg.Name = "numericUpDownAvg";
            this.numericUpDownAvg.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownAvg.TabIndex = 15;
            this.numericUpDownAvg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownStop
            // 
            this.numericUpDownStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownStop.DecimalPlaces = 3;
            this.numericUpDownStop.Location = new System.Drawing.Point(143, 34);
            this.numericUpDownStop.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownStop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStop.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStop.Name = "numericUpDownStop";
            this.numericUpDownStop.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownStop.TabIndex = 11;
            this.numericUpDownStop.Value = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(60, 0);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(75, 30);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Start (MHz):";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStop
            // 
            this.labelStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(59, 30);
            this.labelStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(76, 30);
            this.labelStop.TabIndex = 1;
            this.labelStop.Text = "Stop (MHz):";
            this.labelStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPoints
            // 
            this.labelPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(88, 60);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(47, 30);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "Points:";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownStart.DecimalPlaces = 3;
            this.numericUpDownStart.Location = new System.Drawing.Point(143, 4);
            this.numericUpDownStart.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStart.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownStart.TabIndex = 10;
            this.numericUpDownStart.Value = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            // 
            // labelMeasure
            // 
            this.labelMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMeasure.AutoSize = true;
            this.labelMeasure.Location = new System.Drawing.Point(72, 115);
            this.labelMeasure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeasure.Name = "labelMeasure";
            this.labelMeasure.Size = new System.Drawing.Size(63, 32);
            this.labelMeasure.TabIndex = 6;
            this.labelMeasure.Text = "Measure:";
            this.labelMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMeasure
            // 
            this.comboBoxMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMeasure.FormattingEnabled = true;
            this.comboBoxMeasure.Location = new System.Drawing.Point(143, 119);
            this.comboBoxMeasure.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMeasure.Name = "comboBoxMeasure";
            this.comboBoxMeasure.Size = new System.Drawing.Size(179, 24);
            this.comboBoxMeasure.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(83, 147);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 32);
            this.label16.TabIndex = 8;
            this.label16.Text = "Format:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(143, 151);
            this.comboBoxFormat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(179, 24);
            this.comboBoxFormat.TabIndex = 14;
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPoints.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPoints.Location = new System.Drawing.Point(143, 64);
            this.numericUpDownPoints.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPoints.Maximum = new decimal(new int[] {
            16001,
            0,
            0,
            0});
            this.numericUpDownPoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownPoints.TabIndex = 12;
            this.numericUpDownPoints.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.numericUpDownPoints.ValueChanged += new System.EventHandler(this.numericUpDownPoints_ValueChanged);
            // 
            // SelectCST
            // 
            this.SelectCST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectCST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCST.Location = new System.Drawing.Point(143, 183);
            this.SelectCST.Margin = new System.Windows.Forms.Padding(4);
            this.SelectCST.Name = "SelectCST";
            this.SelectCST.Size = new System.Drawing.Size(179, 28);
            this.SelectCST.TabIndex = 17;
            this.SelectCST.Text = "None (NOT working)";
            this.SelectCST.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Location = new System.Drawing.Point(52, 179);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 36);
            this.label17.TabIndex = 18;
            this.label17.Text = "Cal. Set:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.Location = new System.Drawing.Point(48, 268);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 25);
            this.label22.TabIndex = 20;
            this.label22.Text = "IFBW (Hz):";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownIFBW
            // 
            this.numericUpDownIFBW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIFBW.Location = new System.Drawing.Point(143, 272);
            this.numericUpDownIFBW.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownIFBW.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIFBW.Name = "numericUpDownIFBW";
            this.numericUpDownIFBW.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownIFBW.TabIndex = 19;
            this.numericUpDownIFBW.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.Location = new System.Drawing.Point(48, 229);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 39);
            this.label23.TabIndex = 16;
            this.label23.Text = "Avg. Factor:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(36, 550);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(171, 46);
            this.button13.TabIndex = 32;
            this.button13.Text = "Start Movement";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // manualButton
            // 
            this.manualButton.AutoSize = true;
            this.manualButton.Location = new System.Drawing.Point(77, 20);
            this.manualButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(103, 20);
            this.manualButton.TabIndex = 33;
            this.manualButton.TabStop = true;
            this.manualButton.Text = "Manual input";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.CheckedChanged += new System.EventHandler(this.manualButton_CheckedChanged);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(465, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 448);
            this.label9.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(493, 18);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(376, 451);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "Click on button once input has been added. Allows multi intermediate points. This" +
    " textbox displays our parameter values";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // segmentButton
            // 
            this.segmentButton.AutoSize = true;
            this.segmentButton.Location = new System.Drawing.Point(207, 20);
            this.segmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.segmentButton.Name = "segmentButton";
            this.segmentButton.Size = new System.Drawing.Size(113, 20);
            this.segmentButton.TabIndex = 34;
            this.segmentButton.Text = "Segment input";
            this.segmentButton.UseVisualStyleBackColor = true;
            this.segmentButton.CheckedChanged += new System.EventHandler(this.segmentButton_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 16);
            this.label20.TabIndex = 50;
            this.label20.Text = "Mode:";
            // 
            // returnOriginButton
            // 
            this.returnOriginButton.Location = new System.Drawing.Point(1293, 4);
            this.returnOriginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnOriginButton.Name = "returnOriginButton";
            this.returnOriginButton.Size = new System.Drawing.Size(119, 27);
            this.returnOriginButton.TabIndex = 29;
            this.returnOriginButton.Text = "Return to Origin";
            this.returnOriginButton.UseVisualStyleBackColor = true;
            this.returnOriginButton.Click += new System.EventHandler(this.returnOriginButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1200, 252);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(400, 254);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // configBox
            // 
            this.configBox.Controls.Add(this.tabControl2);
            this.configBox.Location = new System.Drawing.Point(1008, 36);
            this.configBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configBox.Name = "configBox";
            this.configBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configBox.Size = new System.Drawing.Size(404, 208);
            this.configBox.TabIndex = 43;
            this.configBox.TabStop = false;
            this.configBox.Text = "Settings";
            this.configBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.StartupConfig);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(5, 18);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(393, 185);
            this.tabControl2.TabIndex = 45;
            // 
            // StartupConfig
            // 
            this.StartupConfig.Controls.Add(this.button25);
            this.StartupConfig.Controls.Add(this.label13);
            this.StartupConfig.Controls.Add(this.button24);
            this.StartupConfig.Controls.Add(this.stepperButton);
            this.StartupConfig.Controls.Add(this.button23);
            this.StartupConfig.Controls.Add(this.textBox8);
            this.StartupConfig.Controls.Add(this.mmButton);
            this.StartupConfig.Controls.Add(this.label21);
            this.StartupConfig.Location = new System.Drawing.Point(4, 25);
            this.StartupConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartupConfig.Name = "StartupConfig";
            this.StartupConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartupConfig.Size = new System.Drawing.Size(385, 156);
            this.StartupConfig.TabIndex = 0;
            this.StartupConfig.Text = "Startup Config";
            this.StartupConfig.UseVisualStyleBackColor = true;
            this.StartupConfig.Click += new System.EventHandler(this.StartupConfig_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(165, 124);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(67, 23);
            this.button25.TabIndex = 53;
            this.button25.Text = "axis-c";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "Unit of Choice:";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(93, 124);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(67, 23);
            this.button24.TabIndex = 52;
            this.button24.Text = "axis-b";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // stepperButton
            // 
            this.stepperButton.AutoSize = true;
            this.stepperButton.Location = new System.Drawing.Point(20, 54);
            this.stepperButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stepperButton.Name = "stepperButton";
            this.stepperButton.Size = new System.Drawing.Size(109, 20);
            this.stepperButton.TabIndex = 47;
            this.stepperButton.TabStop = true;
            this.stepperButton.Text = "Stepper Units";
            this.stepperButton.UseVisualStyleBackColor = true;
            this.stepperButton.CheckedChanged += new System.EventHandler(this.stepperButton_CheckedChanged);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(21, 124);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(67, 23);
            this.button23.TabIndex = 51;
            this.button23.Text = "axis-a";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(21, 98);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(209, 22);
            this.textBox8.TabIndex = 49;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // mmButton
            // 
            this.mmButton.AutoSize = true;
            this.mmButton.Location = new System.Drawing.Point(20, 30);
            this.mmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmButton.Name = "mmButton";
            this.mmButton.Size = new System.Drawing.Size(50, 20);
            this.mmButton.TabIndex = 46;
            this.mmButton.TabStop = true;
            this.mmButton.Text = "mm";
            this.mmButton.UseVisualStyleBackColor = true;
            this.mmButton.CheckedChanged += new System.EventHandler(this.mmButton_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(186, 16);
            this.label21.TabIndex = 50;
            this.label21.Text = "Slew Speed (Stepper Units/s):";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.button26);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.unitCalibrateTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(385, 156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibration (reset on close)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(25, 95);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(223, 56);
            this.richTextBox2.TabIndex = 55;
            this.richTextBox2.Text = "Default values:\nAxis-a, Axis-b: 250\nAxis-c: 25000\n\n\n\n\n\n\n\n\n";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(245, 47);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(105, 43);
            this.button26.TabIndex = 54;
            this.button26.Text = "Axis-a/Axis-b Set";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(164, 47);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(76, 43);
            this.button14.TabIndex = 53;
            this.button14.Text = "Axis-c\r\nSet";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // unitCalibrateTextBox
            // 
            this.unitCalibrateTextBox.Location = new System.Drawing.Point(176, 20);
            this.unitCalibrateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitCalibrateTextBox.Name = "unitCalibrateTextBox";
            this.unitCalibrateTextBox.Size = new System.Drawing.Size(124, 22);
            this.unitCalibrateTextBox.TabIndex = 51;
            this.unitCalibrateTextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Stepper units/mm (INT):";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "CSV files|*.csv|Measurement files|*.dat|All files|*.*";
            this.saveFileDialog.Title = "Save";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1429, 802);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(201, 22);
            this.textBox6.TabIndex = 44;
            this.textBox6.Text = "Made by Patrick Kon 2019";
            // 
            // segmentGridButton
            // 
            this.segmentGridButton.AutoSize = true;
            this.segmentGridButton.Location = new System.Drawing.Point(124, 28);
            this.segmentGridButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.segmentGridButton.Name = "segmentGridButton";
            this.segmentGridButton.Size = new System.Drawing.Size(53, 20);
            this.segmentGridButton.TabIndex = 50;
            this.segmentGridButton.Text = "Grid";
            this.segmentGridButton.UseVisualStyleBackColor = true;
            this.segmentGridButton.CheckedChanged += new System.EventHandler(this.segmentGridButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1647, 888);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.configBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.returnOriginButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GeneralGroup);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Surface Scan 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.GeneralGroup.ResumeLayout(false);
            this.GeneralGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.translatorTabPage.ResumeLayout(false);
            this.segmentBox.ResumeLayout(false);
            this.segmentBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.manualBox.ResumeLayout(false);
            this.manualBox.PerformLayout();
            this.axisCinputBox.ResumeLayout(false);
            this.axisCinputBox.PerformLayout();
            this.PNAtabPage.ResumeLayout(false);
            this.PNAtabPage.PerformLayout();
            this.tableLayoutPanelPNA.ResumeLayout(false);
            this.tableLayoutPanelPNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIFBW)).EndInit();
            this.configBox.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.StartupConfig.ResumeLayout(false);
            this.StartupConfig.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox1;
        private Label label2;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.ComponentModel.BackgroundWorker GClibBackgroundWorker1;
        private ToolStrip MainToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton ConnectStripButton;
        private ToolStripTextBox AddressTextBox;
        private ToolStripButton DisconnectStripButton;
        private GroupBox GeneralGroup;
        private Button button5;
        private Label label4;
        private Button button6;
        private Button button3;
        private Label label3;
        private Button button4;
        private Button button2;
        private Label label1;
        private Button button1;
        private TextBox unitbox;
        private Label label5;
        private Button originButton;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox3;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private Button button11;
        private Button returnOriginButton;
        //private Button button14;
        private Button button15;
        private Button button13;
        private RichTextBox richTextBox1;
        private Label label15;
        private Label label14;
        private RadioButton segmentButton;
        private RadioButton manualButton;
        private Label label19;
        private Label label20;
        private GroupBox manualBox;
        private GroupBox configBox;
        private GroupBox axisCinputBox;
        private ToolStripButton toolStripButton1;
        private TabControl tabControl1;
        private TabPage translatorTabPage;
        private TabPage PNAtabPage;
        private TableLayoutPanel tableLayoutPanelPNA;
        private NumericUpDown numericUpDownAvg;
        private NumericUpDown numericUpDownStop;
        private Label labelStart;
        private Label labelStop;
        private Label labelPoints;
        private NumericUpDown numericUpDownStart;
        private Label labelMeasure;
        private ComboBox comboBoxMeasure;
        private Label label16;
        private ComboBox comboBoxFormat;
        private NumericUpDown numericUpDownPoints;
        private Button SelectCST;
        private Label label17;
        private Label label22;
        private NumericUpDown numericUpDownIFBW;
        private Label label23;
        private SaveFileDialog saveFileDialog;
        private ToolStripButton toolStripButton2;
        private TextBox textBox6;
        private ToolStripButton toolStripButton3;
        private TabControl tabControl2;
        private TabPage StartupConfig;
        private Button button25;
        private Label label13;
        private Button button24;
        private RadioButton stepperButton;
        private Button button23;
        private TextBox textBox8;
        private RadioButton mmButton;
        private Label label21;
        private TabPage tabPage2;
        private GroupBox segmentBox;
        private RadioButton segmentNormalButton;
        private Label label18;
        private Button button18;
        private Button button17;
        private Button button22;
        private Button button16;
        private Button button21;
        private Button btnAStart;
        private Button button19;
        private Button button20;
        private TextBox unitCalibrateTextBox;
        private Label label11;
        private Button button14;
        private Button button26;
        private RichTextBox richTextBox2;
        private Button btnStop;
        private Button button27;
        private Button button29;
        private Button button28;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox9;
        private GroupBox groupBox2;
        private Button button12;
        private RadioButton segmentGridButton;
    }
}

