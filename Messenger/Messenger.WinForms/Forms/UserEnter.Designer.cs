namespace Messenger.WinForms.Forms
{
    partial class UserEnter
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
            this.userAuthorizationControl1 = new Messenger.WinForms.Controls.UserAuthorizationControl();
            this.SuspendLayout();
            // 
            // userAuthorizationControl1
            // 
            this.userAuthorizationControl1.Location = new System.Drawing.Point(12, 12);
            this.userAuthorizationControl1.Name = "userAuthorizationControl1";
            this.userAuthorizationControl1.Size = new System.Drawing.Size(279, 177);
            this.userAuthorizationControl1.TabIndex = 0;
            // 
            // UserEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 204);
            this.Controls.Add(this.userAuthorizationControl1);
            this.Name = "UserEnter";
            this.Text = "UserEnter";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserAuthorizationControl userAuthorization1;
        private Controls.UserAuthorizationControl userAuthorizationControl1;
    }
}