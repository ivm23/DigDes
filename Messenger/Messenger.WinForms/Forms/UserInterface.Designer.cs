namespace Messenger.WinForms.Forms
{
    partial class UserInterface
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
            this.userInterfaceControl1 = new Messenger.WinForms.Controls.UserInterfaceControl();
            this.SuspendLayout();
            // 
            // userInterfaceControl1
            // 
            this.userInterfaceControl1.Location = new System.Drawing.Point(0, 2);
            this.userInterfaceControl1.Name = "userInterfaceControl1";
            this.userInterfaceControl1.Size = new System.Drawing.Size(503, 234);
            this.userInterfaceControl1.TabIndex = 0;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 210);
            this.Controls.Add(this.userInterfaceControl1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserInterfaceControl userInterfaceControl1;
    }
}