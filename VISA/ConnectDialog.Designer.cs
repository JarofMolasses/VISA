namespace VISA
{
    partial class ConnectDialog
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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 22);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(360, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHost_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 59);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(177, 25);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.okButton_MouseClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(195, 59);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(177, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseClick);
            // 
            // ConnectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 96);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.txtHost);
            this.Name = "ConnectDialog";
            this.Text = "ConnectDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}