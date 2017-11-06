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
            this.btnUserDialogs = new System.Windows.Forms.Button();
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInterfaceControl1
            // 
            this.userInterfaceControl1.Location = new System.Drawing.Point(0, 2);
            this.userInterfaceControl1.Name = "userInterfaceControl1";
            this.userInterfaceControl1.Size = new System.Drawing.Size(297, 203);
            this.userInterfaceControl1.TabIndex = 0;
            // 
            // btnUserDialogs
            // 
            this.btnUserDialogs.Location = new System.Drawing.Point(124, 69);
            this.btnUserDialogs.Name = "btnUserDialogs";
            this.btnUserDialogs.Size = new System.Drawing.Size(75, 23);
            this.btnUserDialogs.TabIndex = 1;
            this.btnUserDialogs.Text = "Диалоги";
            this.btnUserDialogs.UseVisualStyleBackColor = true;
            this.btnUserDialogs.Click += new System.EventHandler(this.btnUserDialogs_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.Location = new System.Drawing.Point(124, 98);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(75, 23);
            this.btnUserSetting.TabIndex = 2;
            this.btnUserSetting.Text = "Настройки";
            this.btnUserSetting.UseVisualStyleBackColor = true;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 263);
            this.Controls.Add(this.btnUserSetting);
            this.Controls.Add(this.btnUserDialogs);
            this.Controls.Add(this.userInterfaceControl1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserInterfaceControl userInterfaceControl1;
        private System.Windows.Forms.Button btnUserDialogs;
        private System.Windows.Forms.Button btnUserSetting;
    }
}