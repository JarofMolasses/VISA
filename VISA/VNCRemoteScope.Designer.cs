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
            RemoteViewing.Vnc.VncClient vncClient1 = new RemoteViewing.Vnc.VncClient();
            this.connectScopeButton = new System.Windows.Forms.Button();
            this.disconnectScopeButton = new System.Windows.Forms.Button();
            this.vncControl1 = new RemoteViewing.Windows.Forms.VncControl();
            this.SuspendLayout();
            // 
            // connectScopeButton
            // 
            this.connectScopeButton.Location = new System.Drawing.Point(2, 774);
            this.connectScopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectScopeButton.Name = "connectScopeButton";
            this.connectScopeButton.Size = new System.Drawing.Size(483, 27);
            this.connectScopeButton.TabIndex = 1;
            this.connectScopeButton.Text = "Connect to scope";
            this.connectScopeButton.UseVisualStyleBackColor = true;
            this.connectScopeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connectScopeButton_MouseClick);
            // 
            // disconnectScopeButton
            // 
            this.disconnectScopeButton.Location = new System.Drawing.Point(489, 774);
            this.disconnectScopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.disconnectScopeButton.Name = "disconnectScopeButton";
            this.disconnectScopeButton.Size = new System.Drawing.Size(537, 27);
            this.disconnectScopeButton.TabIndex = 2;
            this.disconnectScopeButton.Text = "Disconnect scope";
            this.disconnectScopeButton.UseVisualStyleBackColor = true;
            this.disconnectScopeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.disconnectScopeButton_MouseClick);
            // 
            // vncControl1
            // 
            this.vncControl1.AllowClipboardSharingFromServer = false;
            this.vncControl1.AllowClipboardSharingToServer = false;
            this.vncControl1.AllowInput = false;
            this.vncControl1.AllowRemoteCursor = false;
            this.vncControl1.BackColor = System.Drawing.Color.Black;
            vncClient1.MaxUpdateRate = 15D;
            vncClient1.UserData = null;
            this.vncControl1.Client = vncClient1;
            this.vncControl1.Location = new System.Drawing.Point(2, 1);
            this.vncControl1.Name = "vncControl1";
            this.vncControl1.Size = new System.Drawing.Size(1024, 768);
            this.vncControl1.TabIndex = 3;
            this.vncControl1.MouseEnter += new System.EventHandler(this.vncControl1_MouseEnter);
            // 
            // VNCRemoteScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 810);
            this.Controls.Add(this.vncControl1);
            this.Controls.Add(this.disconnectScopeButton);
            this.Controls.Add(this.connectScopeButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VNCRemoteScope";
            this.Text = "VNCRemoteScope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNCRemoteScope_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button connectScopeButton;
        private System.Windows.Forms.Button disconnectScopeButton;
        private RemoteViewing.Windows.Forms.VncControl vncControl1;
    }
}