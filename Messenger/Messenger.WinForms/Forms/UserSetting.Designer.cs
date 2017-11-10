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
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.userSettingControl1 = new Messenger.WinForms.Controls.UserSettingControl();
            this.SuspendLayout();
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(35, 221);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(168, 23);
            this.btnDelUser.TabIndex = 1;
            this.btnDelUser.Text = "Удалить пользователя";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(222, 265);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 51);
            this.btnSaveUser.TabIndex = 2;
            this.btnSaveUser.Text = "Сохранить изменения";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 51);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // userSettingControl1
            // 
            this.userSettingControl1.Location = new System.Drawing.Point(12, -14);
            this.userSettingControl1.Name = "userSettingControl1";
            this.userSettingControl1.Size = new System.Drawing.Size(345, 229);
            this.userSettingControl1.TabIndex = 4;
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 358);
            this.Controls.Add(this.userSettingControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.btnDelUser);
            this.Name = "UserSetting";
            this.Text = "UserSettingcs";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancel;
        private Controls.UserSettingControl userSettingControl1;
    }
}