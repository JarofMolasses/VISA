﻿namespace VISA
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
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openResourcesListBox = new System.Windows.Forms.ListBox();
            this.findResourceButton = new System.Windows.Forms.Button();
            this.visaResourceNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ivTabControl = new System.Windows.Forms.TabControl();
            this.ivCRtab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startResTextBox = new System.Windows.Forms.TextBox();
            this.resStepTextBox = new System.Windows.Forms.TextBox();
            this.stopResTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ivCCtab = new System.Windows.Forms.TabPage();
            this.ivCVtab = new System.Windows.Forms.TabPage();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ivTabControl.SuspendLayout();
            this.ivCRtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openSessionButton
            // 
            this.openSessionButton.Location = new System.Drawing.Point(7, 195);
            this.openSessionButton.Margin = new System.Windows.Forms.Padding(4);
            this.openSessionButton.Name = "openSessionButton";
            this.openSessionButton.Size = new System.Drawing.Size(163, 28);
            this.openSessionButton.TabIndex = 0;
            this.openSessionButton.Text = "Open session";
            this.openSessionButton.UseVisualStyleBackColor = true;
            this.openSessionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openSessionButton_MouseClick);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.Location = new System.Drawing.Point(168, 195);
            this.closeSessionButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(175, 28);
            this.closeSessionButton.TabIndex = 1;
            this.closeSessionButton.Text = "Close session";
            this.closeSessionButton.UseVisualStyleBackColor = true;
            this.closeSessionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeSessionButton_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "String to write";
            // 
            // writeTextBox
            // 
            this.writeTextBox.Location = new System.Drawing.Point(20, 52);
            this.writeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(367, 22);
            this.writeTextBox.TabIndex = 3;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(20, 84);
            this.queryButton.Margin = new System.Windows.Forms.Padding(4);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(109, 30);
            this.queryButton.TabIndex = 4;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.queryButton_MouseClick);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(137, 84);
            this.writeButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(121, 31);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.writeButton_MouseClick);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(264, 84);
            this.readButton.Margin = new System.Windows.Forms.Padding(4);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(121, 30);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.readButton_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "String read:";
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(21, 215);
            this.readTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(368, 129);
            this.readTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(20, 352);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(369, 37);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(355, 234);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VISA Session control";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Selected target resource";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Active resources:";
            // 
            // openResourcesListBox
            // 
            this.openResourcesListBox.FormattingEnabled = true;
            this.openResourcesListBox.ItemHeight = 16;
            this.openResourcesListBox.Location = new System.Drawing.Point(24, 295);
            this.openResourcesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.openResourcesListBox.Name = "openResourcesListBox";
            this.openResourcesListBox.Size = new System.Drawing.Size(336, 68);
            this.openResourcesListBox.TabIndex = 9;
            this.openResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.activeResourcesListBox_SelectedIndexChanged);
            // 
            // findResourceButton
            // 
            this.findResourceButton.AutoEllipsis = true;
            this.findResourceButton.Location = new System.Drawing.Point(8, 23);
            this.findResourceButton.Margin = new System.Windows.Forms.Padding(4);
            this.findResourceButton.Name = "findResourceButton";
            this.findResourceButton.Size = new System.Drawing.Size(337, 26);
            this.findResourceButton.TabIndex = 8;
            this.findResourceButton.Text = "Find VISA resources";
            this.findResourceButton.UseVisualStyleBackColor = true;
            this.findResourceButton.Click += new System.EventHandler(this.findResourceButton_Click);
            // 
            // visaResourceNameTextBox
            // 
            this.visaResourceNameTextBox.Location = new System.Drawing.Point(8, 165);
            this.visaResourceNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.visaResourceNameTextBox.Name = "visaResourceNameTextBox";
            this.visaResourceNameTextBox.Size = new System.Drawing.Size(336, 22);
            this.visaResourceNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resource string:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available resources:";
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.FormattingEnabled = true;
            this.availableResourcesListBox.ItemHeight = 16;
            this.availableResourcesListBox.Location = new System.Drawing.Point(8, 73);
            this.availableResourcesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(337, 68);
            this.availableResourcesListBox.TabIndex = 3;
            this.availableResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.availableResourcesListBox_SelectedIndexChanged_1);
            this.availableResourcesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.availableResourcesListBox_MouseDoubleClick);
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(20, 455);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(815, 460);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IV curve plotter";
            // 
            // ivTabControl
            // 
            this.ivTabControl.Controls.Add(this.ivCRtab);
            this.ivTabControl.Controls.Add(this.ivCCtab);
            this.ivTabControl.Controls.Add(this.ivCVtab);
            this.ivTabControl.Location = new System.Drawing.Point(24, 38);
            this.ivTabControl.Name = "ivTabControl";
            this.ivTabControl.SelectedIndex = 0;
            this.ivTabControl.Size = new System.Drawing.Size(280, 151);
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
            this.ivCRtab.Location = new System.Drawing.Point(4, 25);
            this.ivCRtab.Name = "ivCRtab";
            this.ivCRtab.Padding = new System.Windows.Forms.Padding(3);
            this.ivCRtab.Size = new System.Drawing.Size(272, 122);
            this.ivCRtab.TabIndex = 0;
            this.ivCRtab.Text = "CR mode";
            this.ivCRtab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stop resistance [R]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Start resistance [R]:";
            // 
            // startResTextBox
            // 
            this.startResTextBox.Location = new System.Drawing.Point(173, 11);
            this.startResTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.startResTextBox.Name = "startResTextBox";
            this.startResTextBox.Size = new System.Drawing.Size(65, 22);
            this.startResTextBox.TabIndex = 6;
            // 
            // resStepTextBox
            // 
            this.resStepTextBox.Location = new System.Drawing.Point(173, 68);
            this.resStepTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resStepTextBox.Name = "resStepTextBox";
            this.resStepTextBox.Size = new System.Drawing.Size(65, 22);
            this.resStepTextBox.TabIndex = 1;
            // 
            // stopResTextBox
            // 
            this.stopResTextBox.Location = new System.Drawing.Point(173, 39);
            this.stopResTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stopResTextBox.Name = "stopResTextBox";
            this.stopResTextBox.Size = new System.Drawing.Size(65, 22);
            this.stopResTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resistance step [R]:";
            // 
            // ivCCtab
            // 
            this.ivCCtab.Location = new System.Drawing.Point(4, 25);
            this.ivCCtab.Name = "ivCCtab";
            this.ivCCtab.Padding = new System.Windows.Forms.Padding(3);
            this.ivCCtab.Size = new System.Drawing.Size(272, 122);
            this.ivCCtab.TabIndex = 1;
            this.ivCCtab.Text = "CC mode";
            this.ivCCtab.UseVisualStyleBackColor = true;
            // 
            // ivCVtab
            // 
            this.ivCVtab.Location = new System.Drawing.Point(4, 25);
            this.ivCVtab.Name = "ivCVtab";
            this.ivCVtab.Padding = new System.Windows.Forms.Padding(3);
            this.ivCVtab.Size = new System.Drawing.Size(272, 122);
            this.ivCVtab.TabIndex = 2;
            this.ivCVtab.Text = "CV mode";
            this.ivCVtab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 423);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Test progress:";
            // 
            // testProgressTextBox
            // 
            this.testProgressTextBox.Location = new System.Drawing.Point(641, 420);
            this.testProgressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.testProgressTextBox.Name = "testProgressTextBox";
            this.testProgressTextBox.Size = new System.Drawing.Size(155, 22);
            this.testProgressTextBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(172, 391);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 38);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel test";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseClick);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(25, 253);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(279, 30);
            this.selectFileButton.TabIndex = 10;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectFileButton_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Step time [s]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Save to file:";
            // 
            // stepTimeTextBox
            // 
            this.stepTimeTextBox.Location = new System.Drawing.Point(199, 201);
            this.stepTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stepTimeTextBox.Name = "stepTimeTextBox";
            this.stepTimeTextBox.Size = new System.Drawing.Size(65, 22);
            this.stepTimeTextBox.TabIndex = 13;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(28, 307);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameTextBox.Multiline = true;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(276, 75);
            this.fileNameTextBox.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(348, 38);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(448, 360);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // ivStartButton
            // 
            this.ivStartButton.Location = new System.Drawing.Point(28, 391);
            this.ivStartButton.Margin = new System.Windows.Forms.Padding(4);
            this.ivStartButton.Name = "ivStartButton";
            this.ivStartButton.Size = new System.Drawing.Size(136, 38);
            this.ivStartButton.TabIndex = 0;
            this.ivStartButton.Text = "Start IV test";
            this.ivStartButton.UseVisualStyleBackColor = true;
            this.ivStartButton.Click += new System.EventHandler(this.ivStartButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queryIDShortcutButton);
            this.groupBox3.Controls.Add(this.clearButton);
            this.groupBox3.Controls.Add(this.readTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.readButton);
            this.groupBox3.Controls.Add(this.writeButton);
            this.groupBox3.Controls.Add(this.queryButton);
            this.groupBox3.Controls.Add(this.writeTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(427, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 398);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual read/write";
            // 
            // queryIDShortcutButton
            // 
            this.queryIDShortcutButton.Location = new System.Drawing.Point(20, 122);
            this.queryIDShortcutButton.Name = "queryIDShortcutButton";
            this.queryIDShortcutButton.Size = new System.Drawing.Size(369, 35);
            this.queryIDShortcutButton.TabIndex = 10;
            this.queryIDShortcutButton.Text = "Query *ID?\\n";
            this.queryIDShortcutButton.UseVisualStyleBackColor = true;
            this.queryIDShortcutButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.queryIDShortcutButton_MouseClick);
            // 
            // selectedTargetResourceTextBox
            // 
            this.selectedTargetResourceTextBox.Location = new System.Drawing.Point(25, 389);
            this.selectedTargetResourceTextBox.Name = "selectedTargetResourceTextBox";
            this.selectedTargetResourceTextBox.Size = new System.Drawing.Size(333, 22);
            this.selectedTargetResourceTextBox.TabIndex = 13;
            // 
            // visaInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 928);
            this.Controls.Add(this.openResourcesListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectedTargetResourceTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "visaInterface";
            this.Text = "VISA interface GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ivTabControl.ResumeLayout(false);
            this.ivCRtab.ResumeLayout(false);
            this.ivCRtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resStepTextBox;
        private System.Windows.Forms.Button ivStartButton;
        private System.Windows.Forms.TextBox startResTextBox;
        private System.Windows.Forms.TextBox stopResTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TabControl ivTabControl;
        private System.Windows.Forms.TabPage ivCRtab;
        private System.Windows.Forms.TabPage ivCCtab;
        private System.Windows.Forms.TabPage ivCVtab;
        private System.Windows.Forms.TextBox selectedTargetResourceTextBox;
    }
}

