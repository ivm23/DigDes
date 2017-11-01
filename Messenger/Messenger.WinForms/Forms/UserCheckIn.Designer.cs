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
            this.userCheckInControl1 = new Messenger.WinForms.Controls.UserCheckInControl();
            this.SuspendLayout();
            // 
            // userCheckInControl1
            // 
            this.userCheckInControl1.Location = new System.Drawing.Point(1, 3);
            this.userCheckInControl1.Name = "userCheckInControl1";
            this.userCheckInControl1.Size = new System.Drawing.Size(459, 349);
            this.userCheckInControl1.TabIndex = 0;
            // 
            // UserCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 356);
            this.Controls.Add(this.userCheckInControl1);
            this.Name = "UserCheckIn";
            this.Text = "UserCheckIn";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserCheckInControl userCheckInControl1;
    }
}