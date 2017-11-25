namespace Messenger.WinForms.Controls
{
    partial class UserCheckInControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCheckInControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.txtUserSecondName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCancelCheckIn = new System.Windows.Forms.Button();
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(19, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Загрузить фотографию :";
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.BackColor = System.Drawing.Color.RosyBrown;
            this.txtUserFirstName.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUserFirstName.Location = new System.Drawing.Point(153, 49);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtUserFirstName.TabIndex = 5;
            // 
            // txtUserSecondName
            // 
            this.txtUserSecondName.BackColor = System.Drawing.Color.RosyBrown;
            this.txtUserSecondName.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUserSecondName.Location = new System.Drawing.Point(153, 78);
            this.txtUserSecondName.Name = "txtUserSecondName";
            this.txtUserSecondName.Size = new System.Drawing.Size(100, 26);
            this.txtUserSecondName.TabIndex = 6;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.RosyBrown;
            this.txtUserPassword.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUserPassword.Location = new System.Drawing.Point(153, 107);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 26);
            this.txtUserPassword.TabIndex = 7;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectPicture.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSelectPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSelectPicture.Location = new System.Drawing.Point(231, 195);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(99, 47);
            this.btnSelectPicture.TabIndex = 9;
            this.btnSelectPicture.Text = "Обзор...";
            this.btnSelectPicture.UseVisualStyleBackColor = false;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.SystemColors.Window;
            this.btnCheckIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheckIn.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCheckIn.Location = new System.Drawing.Point(191, 302);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(124, 50);
            this.btnCheckIn.TabIndex = 10;
            this.btnCheckIn.Text = "Регистрация";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCancelCheckIn
            // 
            this.btnCancelCheckIn.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelCheckIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCheckIn.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelCheckIn.Location = new System.Drawing.Point(330, 304);
            this.btnCancelCheckIn.Name = "btnCancelCheckIn";
            this.btnCancelCheckIn.Size = new System.Drawing.Size(129, 50);
            this.btnCancelCheckIn.TabIndex = 11;
            this.btnCancelCheckIn.Text = "Отмена";
            this.btnCancelCheckIn.UseVisualStyleBackColor = false;
            // 
            // pbUserPhoto
            // 
            this.pbUserPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbUserPhoto.Location = new System.Drawing.Point(354, 160);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(88, 122);
            this.pbUserPhoto.TabIndex = 12;
            this.pbUserPhoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Логин :";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BackColor = System.Drawing.Color.RosyBrown;
            this.txtUserLogin.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUserLogin.Location = new System.Drawing.Point(153, 19);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(100, 26);
            this.txtUserLogin.TabIndex = 14;
            // 
            // UserCheckInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbUserPhoto);
            this.Controls.Add(this.btnCancelCheckIn);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserSecondName);
            this.Controls.Add(this.txtUserFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserCheckInControl";
            this.Size = new System.Drawing.Size(478, 368);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.TextBox txtUserSecondName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCancelCheckIn;
        private System.Windows.Forms.PictureBox pbUserPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserLogin;
    }
}
