﻿namespace Messenger.WinForms.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEnter));
            this.userAuthorizationControl1 = new Messenger.WinForms.Controls.UserAuthorizationControl();
            this.SuspendLayout();
            // 
            // userAuthorizationControl1
            // 
            this.userAuthorizationControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userAuthorizationControl1.BackgroundImage")));
            this.userAuthorizationControl1.Location = new System.Drawing.Point(1, -2);
            this.userAuthorizationControl1.Name = "userAuthorizationControl1";
            this.userAuthorizationControl1.Size = new System.Drawing.Size(304, 158);
            this.userAuthorizationControl1.TabIndex = 0;
            // 
            // UserEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 154);
            this.Controls.Add(this.userAuthorizationControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserEnter";
            this.Text = "PANDAEnter";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserAuthorizationControl userAuthorizationControl1;
    }
}