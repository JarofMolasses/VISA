namespace vncRemoteScope
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
            this.rd = new VncSharp.RemoteDesktop();
            this.connectScopeButton = new System.Windows.Forms.Button();
            this.disconnectScopeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rd
            // 
            this.rd.AutoScroll = true;
            this.rd.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.rd.Location = new System.Drawing.Point(12, 12);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(722, 396);
            this.rd.TabIndex = 0;
            // 
            // connectScopeButton
            // 
            this.connectScopeButton.Location = new System.Drawing.Point(12, 426);
            this.connectScopeButton.Name = "connectScopeButton";
            this.connectScopeButton.Size = new System.Drawing.Size(138, 27);
            this.connectScopeButton.TabIndex = 1;
            this.connectScopeButton.Text = "Connect to scope";
            this.connectScopeButton.UseVisualStyleBackColor = true;
            // 
            // disconnectScopeButton
            // 
            this.disconnectScopeButton.Location = new System.Drawing.Point(156, 426);
            this.disconnectScopeButton.Name = "disconnectScopeButton";
            this.disconnectScopeButton.Size = new System.Drawing.Size(164, 27);
            this.disconnectScopeButton.TabIndex = 2;
            this.disconnectScopeButton.Text = "Disconnect from scope";
            this.disconnectScopeButton.UseVisualStyleBackColor = true;
            // 
            // VNCRemoteScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 562);
            this.Controls.Add(this.disconnectScopeButton);
            this.Controls.Add(this.connectScopeButton);
            this.Controls.Add(this.rd);
            this.Name = "VNCRemoteScope";
            this.Text = "VNC remote scope ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNCRemoteScope_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private VncSharp.RemoteDesktop rd;
        private System.Windows.Forms.Button connectScopeButton;
        private System.Windows.Forms.Button disconnectScopeButton;
    }
}

