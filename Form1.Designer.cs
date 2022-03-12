namespace shutupedge
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
            this.removebrowser = new System.Windows.Forms.Button();
            this.installbrowser = new System.Windows.Forms.Button();
            this.browserInstallStatus = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removebrowser
            // 
            this.removebrowser.Location = new System.Drawing.Point(12, 45);
            this.removebrowser.Name = "removebrowser";
            this.removebrowser.Size = new System.Drawing.Size(281, 46);
            this.removebrowser.TabIndex = 0;
            this.removebrowser.Text = "Uninstall Microsoft Edge";
            this.removebrowser.UseVisualStyleBackColor = true;
            this.removebrowser.Click += new System.EventHandler(this.removebrowser_Click);
            // 
            // installbrowser
            // 
            this.installbrowser.Location = new System.Drawing.Point(12, 97);
            this.installbrowser.Name = "installbrowser";
            this.installbrowser.Size = new System.Drawing.Size(281, 46);
            this.installbrowser.TabIndex = 1;
            this.installbrowser.Text = "Install Microsoft Edge";
            this.installbrowser.UseVisualStyleBackColor = true;
            this.installbrowser.Click += new System.EventHandler(this.installbrowser_Click);
            // 
            // browserInstallStatus
            // 
            this.browserInstallStatus.AutoSize = true;
            this.browserInstallStatus.Location = new System.Drawing.Point(12, 13);
            this.browserInstallStatus.Name = "browserInstallStatus";
            this.browserInstallStatus.Size = new System.Drawing.Size(134, 13);
            this.browserInstallStatus.TabIndex = 2;
            this.browserInstallStatus.Text = "github/Ma0us/shutupedge";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(270, 16);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 23);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 155);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.browserInstallStatus);
            this.Controls.Add(this.installbrowser);
            this.Controls.Add(this.removebrowser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 194);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutUpEdge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removebrowser;
        private System.Windows.Forms.Button installbrowser;
        private System.Windows.Forms.Label browserInstallStatus;
        private System.Windows.Forms.Button helpButton;
    }
}

