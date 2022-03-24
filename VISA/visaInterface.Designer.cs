namespace VISA
{
    partial class visaInterface
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openSessionButton = new System.Windows.Forms.Button();
            this.closeSessionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findResourceButton = new System.Windows.Forms.Button();
            this.visaResourceNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openResourcesListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ivTargetDaqNameDropdown = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ivTargetLoadNameDropdown = new System.Windows.Forms.ComboBox();
            this.averagingCheckBox = new System.Windows.Forms.CheckBox();
            this.ivTabControl = new System.Windows.Forms.TabControl();
            this.ivCRtab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startResTextBox = new System.Windows.Forms.TextBox();
            this.resStepTextBox = new System.Windows.Forms.TextBox();
            this.stopResTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ivCCtab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.startCurrentTextBox = new System.Windows.Forms.TextBox();
            this.curStepTextBox = new System.Windows.Forms.TextBox();
            this.stopCurrentTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ivCVtab = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.startVoltageTextBox = new System.Windows.Forms.TextBox();
            this.voltStepTextBox = new System.Windows.Forms.TextBox();
            this.stopVoltageTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.testProgressTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stepTimeTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ivStartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queryIDShortcutButton = new System.Windows.Forms.Button();
            this.selectedTargetResourceTextBox = new System.Windows.Forms.TextBox();
            this.clearIVTargetSelectionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ivTabControl.SuspendLayout();
            this.ivCRtab.SuspendLayout();
            this.ivCCtab.SuspendLayout();
            this.ivCVtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openSessionButton
            // 
            this.openSessionButton.Location = new System.Drawing.Point(5, 158);
            this.openSessionButton.Name = "openSessionButton";
            this.openSessionButton.Size = new System.Drawing.Size(122, 23);
            this.openSessionButton.TabIndex = 0;
            this.openSessionButton.Text = "Open session";
            this.openSessionButton.UseVisualStyleBackColor = true;
            this.openSessionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openSessionButton_MouseClick);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.Location = new System.Drawing.Point(126, 158);
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(131, 23);
            this.closeSessionButton.TabIndex = 1;
            this.closeSessionButton.Text = "Close session";
            this.closeSessionButton.UseVisualStyleBackColor = true;
            this.closeSessionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeSessionButton_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "String to write:";
            // 
            // writeTextBox
            // 
            this.writeTextBox.Location = new System.Drawing.Point(17, 166);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(238, 20);
            this.writeTextBox.TabIndex = 3;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(17, 192);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(71, 24);
            this.queryButton.TabIndex = 4;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.queryButton_MouseClick);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(94, 192);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(80, 25);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.writeButton_MouseClick);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(180, 192);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 24);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.readButton_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "String read:";
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(18, 284);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(237, 54);
            this.readTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(17, 344);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(238, 30);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearButton_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findResourceButton);
            this.groupBox1.Controls.Add(this.visaResourceNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.availableResourcesListBox);
            this.groupBox1.Controls.Add(this.closeSessionButton);
            this.groupBox1.Controls.Add(this.openSessionButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VISA Session control";
            // 
            // findResourceButton
            // 
            this.findResourceButton.AutoEllipsis = true;
            this.findResourceButton.Location = new System.Drawing.Point(6, 19);
            this.findResourceButton.Name = "findResourceButton";
            this.findResourceButton.Size = new System.Drawing.Size(253, 21);
            this.findResourceButton.TabIndex = 8;
            this.findResourceButton.Text = "Find VISA resources";
            this.findResourceButton.UseVisualStyleBackColor = true;
            this.findResourceButton.Click += new System.EventHandler(this.findResourceButton_Click);
            // 
            // visaResourceNameTextBox
            // 
            this.visaResourceNameTextBox.Location = new System.Drawing.Point(6, 134);
            this.visaResourceNameTextBox.Name = "visaResourceNameTextBox";
            this.visaResourceNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.visaResourceNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resource string:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available resources:";
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.FormattingEnabled = true;
            this.availableResourcesListBox.Location = new System.Drawing.Point(6, 59);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(254, 56);
            this.availableResourcesListBox.TabIndex = 3;
            this.availableResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.availableResourcesListBox_SelectedIndexChanged_1);
            this.availableResourcesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.availableResourcesListBox_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Selected target resource:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Active resources:";
            // 
            // openResourcesListBox
            // 
            this.openResourcesListBox.FormattingEnabled = true;
            this.openResourcesListBox.Location = new System.Drawing.Point(17, 36);
            this.openResourcesListBox.Name = "openResourcesListBox";
            this.openResourcesListBox.Size = new System.Drawing.Size(239, 56);
            this.openResourcesListBox.TabIndex = 9;
            this.openResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.activeResourcesListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearIVTargetSelectionButton);
            this.groupBox2.Controls.Add(this.ivTargetDaqNameDropdown);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.ivTargetLoadNameDropdown);
            this.groupBox2.Controls.Add(this.averagingCheckBox);
            this.groupBox2.Controls.Add(this.ivTabControl);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.testProgressTextBox);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.selectFileButton);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.stepTimeTextBox);
            this.groupBox2.Controls.Add(this.fileNameTextBox);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.ivStartButton);
            this.groupBox2.Location = new System.Drawing.Point(576, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 430);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IV curve plotter";
            // 
            // ivTargetDaqNameDropdown
            // 
            this.ivTargetDaqNameDropdown.FormattingEnabled = true;
            this.ivTargetDaqNameDropdown.Location = new System.Drawing.Point(94, 47);
            this.ivTargetDaqNameDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivTargetDaqNameDropdown.Name = "ivTargetDaqNameDropdown";
            this.ivTargetDaqNameDropdown.Size = new System.Drawing.Size(120, 21);
            this.ivTargetDaqNameDropdown.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 47);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 15);
            this.label20.TabIndex = 20;
            this.label20.Text = "Target DAQ:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 24);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 15);
            this.label19.TabIndex = 19;
            this.label19.Text = "Target Load:";
            // 
            // ivTargetLoadNameDropdown
            // 
            this.ivTargetLoadNameDropdown.FormattingEnabled = true;
            this.ivTargetLoadNameDropdown.Location = new System.Drawing.Point(94, 18);
            this.ivTargetLoadNameDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivTargetLoadNameDropdown.Name = "ivTargetLoadNameDropdown";
            this.ivTargetLoadNameDropdown.Size = new System.Drawing.Size(121, 21);
            this.ivTargetLoadNameDropdown.TabIndex = 18;
            this.ivTargetLoadNameDropdown.SelectedIndexChanged += new System.EventHandler(this.targetLoadNameDropdown_SelectedIndexChanged);
            // 
            // averagingCheckBox
            // 
            this.averagingCheckBox.AutoSize = true;
            this.averagingCheckBox.Location = new System.Drawing.Point(158, 241);
            this.averagingCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.averagingCheckBox.Name = "averagingCheckBox";
            this.averagingCheckBox.Size = new System.Drawing.Size(83, 19);
            this.averagingCheckBox.TabIndex = 17;
            this.averagingCheckBox.Text = "Averaging";
            this.averagingCheckBox.UseVisualStyleBackColor = true;
            // 
            // ivTabControl
            // 
            this.ivTabControl.Controls.Add(this.ivCRtab);
            this.ivTabControl.Controls.Add(this.ivCCtab);
            this.ivTabControl.Controls.Add(this.ivCVtab);
            this.ivTabControl.Location = new System.Drawing.Point(19, 118);
            this.ivTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivTabControl.Name = "ivTabControl";
            this.ivTabControl.SelectedIndex = 0;
            this.ivTabControl.Size = new System.Drawing.Size(200, 114);
            this.ivTabControl.TabIndex = 16;
            // 
            // ivCRtab
            // 
            this.ivCRtab.Controls.Add(this.label8);
            this.ivCRtab.Controls.Add(this.label7);
            this.ivCRtab.Controls.Add(this.startResTextBox);
            this.ivCRtab.Controls.Add(this.resStepTextBox);
            this.ivCRtab.Controls.Add(this.stopResTextBox);
            this.ivCRtab.Controls.Add(this.label6);
            this.ivCRtab.Location = new System.Drawing.Point(4, 22);
            this.ivCRtab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivCRtab.Name = "ivCRtab";
            this.ivCRtab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivCRtab.Size = new System.Drawing.Size(192, 88);
            this.ivCRtab.TabIndex = 0;
            this.ivCRtab.Text = "CR mode";
            this.ivCRtab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stop resistance [R]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Start resistance [R]:";
            // 
            // startResTextBox
            // 
            this.startResTextBox.Location = new System.Drawing.Point(122, 6);
            this.startResTextBox.Name = "startResTextBox";
            this.startResTextBox.Size = new System.Drawing.Size(50, 20);
            this.startResTextBox.TabIndex = 6;
            // 
            // resStepTextBox
            // 
            this.resStepTextBox.Location = new System.Drawing.Point(122, 61);
            this.resStepTextBox.Name = "resStepTextBox";
            this.resStepTextBox.Size = new System.Drawing.Size(50, 20);
            this.resStepTextBox.TabIndex = 1;
            // 
            // stopResTextBox
            // 
            this.stopResTextBox.Location = new System.Drawing.Point(122, 34);
            this.stopResTextBox.Name = "stopResTextBox";
            this.stopResTextBox.Size = new System.Drawing.Size(50, 20);
            this.stopResTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resistance step [R]:";
            // 
            // ivCCtab
            // 
            this.ivCCtab.Controls.Add(this.label13);
            this.ivCCtab.Controls.Add(this.label14);
            this.ivCCtab.Controls.Add(this.startCurrentTextBox);
            this.ivCCtab.Controls.Add(this.curStepTextBox);
            this.ivCCtab.Controls.Add(this.stopCurrentTextBox);
            this.ivCCtab.Controls.Add(this.label15);
            this.ivCCtab.Location = new System.Drawing.Point(4, 22);
            this.ivCCtab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivCCtab.Name = "ivCCtab";
            this.ivCCtab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivCCtab.Size = new System.Drawing.Size(192, 88);
            this.ivCCtab.TabIndex = 1;
            this.ivCCtab.Text = "CC mode";
            this.ivCCtab.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Stop current [A]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 12);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Start current [A]:";
            // 
            // startCurrentTextBox
            // 
            this.startCurrentTextBox.Location = new System.Drawing.Point(117, 6);
            this.startCurrentTextBox.Name = "startCurrentTextBox";
            this.startCurrentTextBox.Size = new System.Drawing.Size(50, 20);
            this.startCurrentTextBox.TabIndex = 12;
            // 
            // curStepTextBox
            // 
            this.curStepTextBox.Location = new System.Drawing.Point(117, 58);
            this.curStepTextBox.Name = "curStepTextBox";
            this.curStepTextBox.Size = new System.Drawing.Size(50, 20);
            this.curStepTextBox.TabIndex = 7;
            // 
            // stopCurrentTextBox
            // 
            this.stopCurrentTextBox.Location = new System.Drawing.Point(117, 32);
            this.stopCurrentTextBox.Name = "stopCurrentTextBox";
            this.stopCurrentTextBox.Size = new System.Drawing.Size(50, 20);
            this.stopCurrentTextBox.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Current step [A]:";
            // 
            // ivCVtab
            // 
            this.ivCVtab.Controls.Add(this.label16);
            this.ivCVtab.Controls.Add(this.label17);
            this.ivCVtab.Controls.Add(this.startVoltageTextBox);
            this.ivCVtab.Controls.Add(this.voltStepTextBox);
            this.ivCVtab.Controls.Add(this.stopVoltageTextBox);
            this.ivCVtab.Controls.Add(this.label18);
            this.ivCVtab.Location = new System.Drawing.Point(4, 22);
            this.ivCVtab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivCVtab.Name = "ivCVtab";
            this.ivCVtab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ivCVtab.Size = new System.Drawing.Size(192, 88);
            this.ivCVtab.TabIndex = 2;
            this.ivCVtab.Text = "CV mode";
            this.ivCVtab.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Stop voltage [V]:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 12);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(93, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Start voltage [V]:";
            // 
            // startVoltageTextBox
            // 
            this.startVoltageTextBox.Location = new System.Drawing.Point(117, 10);
            this.startVoltageTextBox.Name = "startVoltageTextBox";
            this.startVoltageTextBox.Size = new System.Drawing.Size(50, 20);
            this.startVoltageTextBox.TabIndex = 18;
            // 
            // voltStepTextBox
            // 
            this.voltStepTextBox.Location = new System.Drawing.Point(117, 61);
            this.voltStepTextBox.Name = "voltStepTextBox";
            this.voltStepTextBox.Size = new System.Drawing.Size(50, 20);
            this.voltStepTextBox.TabIndex = 13;
            // 
            // stopVoltageTextBox
            // 
            this.stopVoltageTextBox.Location = new System.Drawing.Point(117, 34);
            this.stopVoltageTextBox.Name = "stopVoltageTextBox";
            this.stopVoltageTextBox.Size = new System.Drawing.Size(50, 20);
            this.stopVoltageTextBox.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "Voltage step [V]:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Test progress:";
            // 
            // testProgressTextBox
            // 
            this.testProgressTextBox.Location = new System.Drawing.Point(481, 341);
            this.testProgressTextBox.Name = "testProgressTextBox";
            this.testProgressTextBox.Size = new System.Drawing.Size(117, 20);
            this.testProgressTextBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(127, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 31);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel test";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseClick);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(20, 269);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(199, 24);
            this.selectFileButton.TabIndex = 10;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectFileButton_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Step time [s]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Save to file:";
            // 
            // stepTimeTextBox
            // 
            this.stepTimeTextBox.Location = new System.Drawing.Point(93, 240);
            this.stepTimeTextBox.Name = "stepTimeTextBox";
            this.stepTimeTextBox.Size = new System.Drawing.Size(50, 20);
            this.stepTimeTextBox.TabIndex = 13;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(23, 319);
            this.fileNameTextBox.Multiline = true;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(200, 62);
            this.fileNameTextBox.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(251, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(346, 310);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // ivStartButton
            // 
            this.ivStartButton.Location = new System.Drawing.Point(19, 387);
            this.ivStartButton.Name = "ivStartButton";
            this.ivStartButton.Size = new System.Drawing.Size(102, 31);
            this.ivStartButton.TabIndex = 0;
            this.ivStartButton.Text = "Start IV test";
            this.ivStartButton.UseVisualStyleBackColor = true;
            this.ivStartButton.Click += new System.EventHandler(this.ivStartButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openResourcesListBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.queryIDShortcutButton);
            this.groupBox3.Controls.Add(this.selectedTargetResourceTextBox);
            this.groupBox3.Controls.Add(this.clearButton);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.readTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.readButton);
            this.groupBox3.Controls.Add(this.writeButton);
            this.groupBox3.Controls.Add(this.queryButton);
            this.groupBox3.Controls.Add(this.writeTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(281, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(273, 382);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual read/write";
            // 
            // queryIDShortcutButton
            // 
            this.queryIDShortcutButton.Location = new System.Drawing.Point(17, 222);
            this.queryIDShortcutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queryIDShortcutButton.Name = "queryIDShortcutButton";
            this.queryIDShortcutButton.Size = new System.Drawing.Size(238, 28);
            this.queryIDShortcutButton.TabIndex = 10;
            this.queryIDShortcutButton.Text = "Query *ID?\\n";
            this.queryIDShortcutButton.UseVisualStyleBackColor = true;
            this.queryIDShortcutButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.queryIDShortcutButton_MouseClick);
            // 
            // selectedTargetResourceTextBox
            // 
            this.selectedTargetResourceTextBox.Location = new System.Drawing.Point(18, 112);
            this.selectedTargetResourceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedTargetResourceTextBox.Name = "selectedTargetResourceTextBox";
            this.selectedTargetResourceTextBox.Size = new System.Drawing.Size(238, 20);
            this.selectedTargetResourceTextBox.TabIndex = 13;
            // 
            // clearIVTargetSelectionButton
            // 
            this.clearIVTargetSelectionButton.Location = new System.Drawing.Point(93, 73);
            this.clearIVTargetSelectionButton.Name = "clearIVTargetSelectionButton";
            this.clearIVTargetSelectionButton.Size = new System.Drawing.Size(122, 29);
            this.clearIVTargetSelectionButton.TabIndex = 22;
            this.clearIVTargetSelectionButton.Text = "Clear selections";
            this.clearIVTargetSelectionButton.UseVisualStyleBackColor = true;
            this.clearIVTargetSelectionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearIVTargetSelectionButton_MouseClick);
            // 
            // visaInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "visaInterface";
            this.Text = "VISA interface GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ivTabControl.ResumeLayout(false);
            this.ivCRtab.ResumeLayout(false);
            this.ivCRtab.PerformLayout();
            this.ivCCtab.ResumeLayout(false);
            this.ivCCtab.PerformLayout();
            this.ivCVtab.ResumeLayout(false);
            this.ivCVtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSessionButton;
        private System.Windows.Forms.Button closeSessionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox visaResourceNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox availableResourcesListBox;
        private System.Windows.Forms.Button findResourceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox openResourcesListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ivStartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox testProgressTextBox;
        private System.Windows.Forms.TextBox stepTimeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button queryIDShortcutButton;
        private System.Windows.Forms.TextBox selectedTargetResourceTextBox;
        private System.Windows.Forms.CheckBox averagingCheckBox;
        private System.Windows.Forms.TabControl ivTabControl;
        private System.Windows.Forms.TabPage ivCRtab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox startResTextBox;
        private System.Windows.Forms.TextBox resStepTextBox;
        private System.Windows.Forms.TextBox stopResTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage ivCCtab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox startCurrentTextBox;
        private System.Windows.Forms.TextBox curStepTextBox;
        private System.Windows.Forms.TextBox stopCurrentTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage ivCVtab;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox startVoltageTextBox;
        private System.Windows.Forms.TextBox voltStepTextBox;
        private System.Windows.Forms.TextBox stopVoltageTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ivTargetDaqNameDropdown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ivTargetLoadNameDropdown;
        private System.Windows.Forms.Button clearIVTargetSelectionButton;
    }
}

