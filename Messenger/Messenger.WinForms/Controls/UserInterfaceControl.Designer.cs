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
            this.lbUserName = new System.Windows.Forms.Label();
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            this.SuspendLayout();
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
            // pbUserPhoto
            // 
            this.pbUserPhoto.Location = new System.Drawing.Point(16, 13);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(88, 122);
            this.pbUserPhoto.TabIndex = 0;
            this.pbUserPhoto.TabStop = false;
            // 
            // UserInterfaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.pbUserPhoto);
            this.Name = "UserInterfaceControl";
            this.Size = new System.Drawing.Size(291, 177);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserPhoto;
        private System.Windows.Forms.Label lbUserName;
    }
}
