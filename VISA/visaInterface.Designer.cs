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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label5 = new System.Windows.Forms.Label();
            this.activeResourcesListBox = new System.Windows.Forms.ListBox();
            this.findResourceButton = new System.Windows.Forms.Button();
            this.visaResourceNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startResTextBox = new System.Windows.Forms.TextBox();
            this.stopResTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resStepTextBox = new System.Windows.Forms.TextBox();
            this.ivStartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openSessionButton
            // 
            this.openSessionButton.Location = new System.Drawing.Point(6, 182);
            this.openSessionButton.Name = "openSessionButton";
            this.openSessionButton.Size = new System.Drawing.Size(122, 23);
            this.openSessionButton.TabIndex = 0;
            this.openSessionButton.Text = "Open session";
            this.openSessionButton.UseVisualStyleBackColor = true;
            this.openSessionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openSessionButton_MouseClick);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.Location = new System.Drawing.Point(129, 182);
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
            this.label1.Location = new System.Drawing.Point(287, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "String to write";
            // 
            // writeTextBox
            // 
            this.writeTextBox.Location = new System.Drawing.Point(289, 62);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(276, 20);
            this.writeTextBox.TabIndex = 3;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(289, 88);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(82, 24);
            this.queryButton.TabIndex = 4;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.queryButton_MouseClick);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(377, 88);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(91, 25);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.writeButton_MouseClick);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(474, 89);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(91, 24);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.readButton_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "String read:";
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(291, 196);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(277, 63);
            this.readTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(292, 265);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(277, 30);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearButton_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.activeResourcesListBox);
            this.groupBox1.Controls.Add(this.findResourceButton);
            this.groupBox1.Controls.Add(this.visaResourceNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.availableResourcesListBox);
            this.groupBox1.Controls.Add(this.closeSessionButton);
            this.groupBox1.Controls.Add(this.openSessionButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 300);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VISA Session control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Active resources:";
            // 
            // activeResourcesListBox
            // 
            this.activeResourcesListBox.FormattingEnabled = true;
            this.activeResourcesListBox.Location = new System.Drawing.Point(7, 239);
            this.activeResourcesListBox.Name = "activeResourcesListBox";
            this.activeResourcesListBox.Size = new System.Drawing.Size(253, 56);
            this.activeResourcesListBox.TabIndex = 9;
            // 
            // findResourceButton
            // 
            this.findResourceButton.AutoEllipsis = true;
            this.findResourceButton.Location = new System.Drawing.Point(6, 19);
            this.findResourceButton.Name = "findResourceButton";
            this.findResourceButton.Size = new System.Drawing.Size(253, 32);
            this.findResourceButton.TabIndex = 8;
            this.findResourceButton.Text = "Find VISA resources";
            this.findResourceButton.UseVisualStyleBackColor = true;
            this.findResourceButton.Click += new System.EventHandler(this.findResourceButton_Click);
            // 
            // visaResourceNameTextBox
            // 
            this.visaResourceNameTextBox.Location = new System.Drawing.Point(6, 156);
            this.visaResourceNameTextBox.Name = "visaResourceNameTextBox";
            this.visaResourceNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.visaResourceNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resource string:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available resources:";
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.FormattingEnabled = true;
            this.availableResourcesListBox.Location = new System.Drawing.Point(6, 75);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(254, 56);
            this.availableResourcesListBox.TabIndex = 3;
            this.availableResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.availableResourcesListBox_SelectedIndexChanged_1);
            this.availableResourcesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.availableResourcesListBox_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.selectFileButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.fileNameTextBox);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.startResTextBox);
            this.groupBox2.Controls.Add(this.stopResTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.resStepTextBox);
            this.groupBox2.Controls.Add(this.ivStartButton);
            this.groupBox2.Location = new System.Drawing.Point(4, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 265);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IV curve plotter";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(97, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 31);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel test";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseClick);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(7, 117);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(178, 24);
            this.selectFileButton.TabIndex = 10;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectFileButton_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Save to file:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(6, 160);
            this.fileNameTextBox.Multiline = true;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(179, 62);
            this.fileNameTextBox.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(201, 10);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(364, 236);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // startResTextBox
            // 
            this.startResTextBox.Location = new System.Drawing.Point(131, 25);
            this.startResTextBox.Name = "startResTextBox";
            this.startResTextBox.Size = new System.Drawing.Size(50, 20);
            this.startResTextBox.TabIndex = 6;
            // 
            // stopResTextBox
            // 
            this.stopResTextBox.Location = new System.Drawing.Point(131, 51);
            this.stopResTextBox.Name = "stopResTextBox";
            this.stopResTextBox.Size = new System.Drawing.Size(50, 20);
            this.stopResTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stop resistance [R]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 28);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Start resistance [R]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resistance step [R]:";
            // 
            // resStepTextBox
            // 
            this.resStepTextBox.Location = new System.Drawing.Point(131, 77);
            this.resStepTextBox.Name = "resStepTextBox";
            this.resStepTextBox.Size = new System.Drawing.Size(50, 20);
            this.resStepTextBox.TabIndex = 1;
            // 
            // ivStartButton
            // 
            this.ivStartButton.Location = new System.Drawing.Point(7, 228);
            this.ivStartButton.Name = "ivStartButton";
            this.ivStartButton.Size = new System.Drawing.Size(88, 31);
            this.ivStartButton.TabIndex = 0;
            this.ivStartButton.Text = "Start IV test";
            this.ivStartButton.UseVisualStyleBackColor = true;
            this.ivStartButton.Click += new System.EventHandler(this.ivStartButton_Click);
            // 
            // visaInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.writeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "visaInterface";
            this.Text = "VISA interface GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.ListBox activeResourcesListBox;
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
    }
}

