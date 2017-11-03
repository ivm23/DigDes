namespace Messenger.WinForms.Controls
{
    partial class UserInterfaceControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnUserChats = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUserPhoto
            // 
            this.pbUserPhoto.Location = new System.Drawing.Point(16, 13);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(88, 122);
            this.pbUserPhoto.TabIndex = 0;
            this.pbUserPhoto.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.SystemColors.Info;
            this.lbUserName.Location = new System.Drawing.Point(123, 13);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 13);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "                ";
            // 
            // btnUserChats
            // 
            this.btnUserChats.Location = new System.Drawing.Point(126, 50);
            this.btnUserChats.Name = "btnUserChats";
            this.btnUserChats.Size = new System.Drawing.Size(91, 33);
            this.btnUserChats.TabIndex = 2;
            this.btnUserChats.Text = "Диалоги";
            this.btnUserChats.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(126, 102);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(91, 33);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Настройки";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // UserInterfaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnUserChats);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.pbUserPhoto);
            this.Name = "UserInterfaceControl";
            this.Size = new System.Drawing.Size(365, 177);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserPhoto;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnUserChats;
        private System.Windows.Forms.Button btnSetting;
    }
}
