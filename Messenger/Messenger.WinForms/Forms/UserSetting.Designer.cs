namespace Messenger.WinForms.Forms
{
    partial class UserSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetting));
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.userSettingControl1 = new Messenger.WinForms.Controls.UserSettingControl();
            this.SuspendLayout();
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelUser.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelUser.Location = new System.Drawing.Point(27, 300);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(138, 48);
            this.btnDelUser.TabIndex = 1;
            this.btnDelUser.Text = "Удалить пользователя";
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveUser.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveUser.Location = new System.Drawing.Point(27, 387);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(138, 51);
            this.btnSaveUser.TabIndex = 2;
            this.btnSaveUser.Text = "Сохранить изменения";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(187, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 51);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // userSettingControl1
            // 
            this.userSettingControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userSettingControl1.BackgroundImage")));
            this.userSettingControl1.Location = new System.Drawing.Point(-1, -4);
            this.userSettingControl1.Name = "userSettingControl1";
            this.userSettingControl1.Size = new System.Drawing.Size(345, 477);
            this.userSettingControl1.TabIndex = 4;
            this.userSettingControl1.UserFirstName = "";
            this.userSettingControl1.UserLogin = "";
            this.userSettingControl1.UserSecondName = "";
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 472);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.userSettingControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserSetting";
            this.Text = "PANDASettingcs";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancel;
        private Controls.UserSettingControl userSettingControl1;
    }
}