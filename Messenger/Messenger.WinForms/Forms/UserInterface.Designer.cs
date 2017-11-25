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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.btnUserDialogs = new System.Windows.Forms.Button();
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.userInterfaceControl1 = new Messenger.WinForms.Controls.UserInterfaceControl();
            this.SuspendLayout();
            // 
            // btnUserDialogs
            // 
            this.btnUserDialogs.BackColor = System.Drawing.SystemColors.Window;
            this.btnUserDialogs.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUserDialogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUserDialogs.Location = new System.Drawing.Point(124, 69);
            this.btnUserDialogs.Name = "btnUserDialogs";
            this.btnUserDialogs.Size = new System.Drawing.Size(102, 48);
            this.btnUserDialogs.TabIndex = 1;
            this.btnUserDialogs.Text = "Диалоги";
            this.btnUserDialogs.UseVisualStyleBackColor = false;
            this.btnUserDialogs.Click += new System.EventHandler(this.btnUserDialogs_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.BackColor = System.Drawing.SystemColors.Window;
            this.btnUserSetting.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUserSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUserSetting.Location = new System.Drawing.Point(124, 137);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(102, 49);
            this.btnUserSetting.TabIndex = 2;
            this.btnUserSetting.Text = "Настройки";
            this.btnUserSetting.UseVisualStyleBackColor = false;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // userInterfaceControl1
            // 
            this.userInterfaceControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInterfaceControl1.BackgroundImage")));
            this.userInterfaceControl1.Location = new System.Drawing.Point(0, 2);
            this.userInterfaceControl1.Name = "userInterfaceControl1";
            this.userInterfaceControl1.Size = new System.Drawing.Size(262, 222);
            this.userInterfaceControl1.TabIndex = 0;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 222);
            this.Controls.Add(this.btnUserSetting);
            this.Controls.Add(this.btnUserDialogs);
            this.Controls.Add(this.userInterfaceControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "PANDAInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserInterfaceControl userInterfaceControl1;
        private System.Windows.Forms.Button btnUserDialogs;
        private System.Windows.Forms.Button btnUserSetting;
    }
}