namespace VISA
{
    partial class VNCRemoteScope
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
            RemoteViewing.Vnc.VncClient vncClient2 = new RemoteViewing.Vnc.VncClient();
            this.connectScopeButton = new System.Windows.Forms.Button();
            this.disconnectScopeButton = new System.Windows.Forms.Button();
            this.vncControl1 = new RemoteViewing.Windows.Forms.VncControl();
            this.scopeScreenShotButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clientStatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // connectScopeButton
            // 
            this.connectScopeButton.Location = new System.Drawing.Point(2, 774);
            this.connectScopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectScopeButton.Name = "connectScopeButton";
            this.connectScopeButton.Size = new System.Drawing.Size(188, 27);
            this.connectScopeButton.TabIndex = 1;
            this.connectScopeButton.Text = "Connect to scope";
            this.connectScopeButton.UseVisualStyleBackColor = true;
            this.connectScopeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connectScopeButton_MouseClick);
            // 
            // disconnectScopeButton
            // 
            this.disconnectScopeButton.Location = new System.Drawing.Point(194, 774);
            this.disconnectScopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.disconnectScopeButton.Name = "disconnectScopeButton";
            this.disconnectScopeButton.Size = new System.Drawing.Size(192, 27);
            this.disconnectScopeButton.TabIndex = 2;
            this.disconnectScopeButton.Text = "Disconnect scope";
            this.disconnectScopeButton.UseVisualStyleBackColor = true;
            this.disconnectScopeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.disconnectScopeButton_MouseClick);
            // 
            // vncControl1
            // 
            this.vncControl1.AllowClipboardSharingFromServer = false;
            this.vncControl1.AllowClipboardSharingToServer = false;
            this.vncControl1.AllowRemoteCursor = false;
            this.vncControl1.BackColor = System.Drawing.Color.Black;
            vncClient2.MaxUpdateRate = 15D;
            vncClient2.UserData = null;
            this.vncControl1.Client = vncClient2;
            this.vncControl1.Location = new System.Drawing.Point(0, 0);
            this.vncControl1.Name = "vncControl1";
            this.vncControl1.Size = new System.Drawing.Size(1024, 768);
            this.vncControl1.TabIndex = 3;
            this.vncControl1.MouseEnter += new System.EventHandler(this.vncControl1_MouseEnter);
            // 
            // scopeScreenShotButton
            // 
            this.scopeScreenShotButton.Location = new System.Drawing.Point(748, 777);
            this.scopeScreenShotButton.Name = "scopeScreenShotButton";
            this.scopeScreenShotButton.Size = new System.Drawing.Size(267, 27);
            this.scopeScreenShotButton.TabIndex = 4;
            this.scopeScreenShotButton.Text = "Save screenshot";
            this.scopeScreenShotButton.UseVisualStyleBackColor = true;
            this.scopeScreenShotButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scopeScreenShotButton_MouseClick);
            // 
            // clientStatusTextBox
            // 
            this.clientStatusTextBox.Location = new System.Drawing.Point(492, 777);
            this.clientStatusTextBox.Name = "clientStatusTextBox";
            this.clientStatusTextBox.Size = new System.Drawing.Size(129, 22);
            this.clientStatusTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 782);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client status:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VNCRemoteScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 809);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientStatusTextBox);
            this.Controls.Add(this.scopeScreenShotButton);
            this.Controls.Add(this.vncControl1);
            this.Controls.Add(this.disconnectScopeButton);
            this.Controls.Add(this.connectScopeButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VNCRemoteScope";
            this.Text = "VNC remote scope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNCRemoteScope_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectScopeButton;
        private System.Windows.Forms.Button disconnectScopeButton;
        private RemoteViewing.Windows.Forms.VncControl vncControl1;
        private System.Windows.Forms.Button scopeScreenShotButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox clientStatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}