namespace Messenger.WinForms.Forms
{
    partial class UserCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCheckIn));
            this.userCheckInControl1 = new Messenger.WinForms.Controls.UserCheckInControl();
            this.SuspendLayout();
            // 
            // userCheckInControl1
            // 
            this.userCheckInControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userCheckInControl1.BackgroundImage")));
            this.userCheckInControl1.Location = new System.Drawing.Point(-1, -2);
            this.userCheckInControl1.Name = "userCheckInControl1";
            this.userCheckInControl1.Size = new System.Drawing.Size(473, 365);
            this.userCheckInControl1.TabIndex = 0;
            // 
            // UserCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 364);
            this.Controls.Add(this.userCheckInControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "UserCheckIn";
            this.Text = "PANDACheckIn";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserCheckInControl userCheckInControl1;
    }
}