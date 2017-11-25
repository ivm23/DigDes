using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Model;

namespace Messenger.WinForms.Forms
{
    public partial class UserSetting : Form
    {
        User _user;
        public UserSetting(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public string UserFirstName
        {
            set { userSettingControl1.UserFirstName = value; }
            get { return userSettingControl1.UserFirstName; }
        }
        public string UserSecondName
        {
            set { userSettingControl1.UserSecondName = value; }
            get { return userSettingControl1.UserSecondName; }
        }
        public string UserLogin
        {
            set { userSettingControl1.UserLogin = value; }
            get { return userSettingControl1.UserLogin; }
        }
        public string UserPassword
        {
            get { return userSettingControl1.UserPassword; }
        }
        public string RepeatUserPassword
        {
            get { return userSettingControl1.RepeatUserPassword; }
        }
    
        private void btnDelUser_Click(object sender, EventArgs e)
        {

            Close();
            Data.EventHandlerDelUser(_user);
            
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (userSettingControl1.UserLogin != "") _user.Login = userSettingControl1.UserLogin;
            if (userSettingControl1.UserFirstName != "") _user.FirstName = userSettingControl1.UserFirstName;

            if (userSettingControl1.UserSecondName != "") _user.SecondName = userSettingControl1.UserSecondName;

            if (userSettingControl1.UserPassword != "" &&
                userSettingControl1.RepeatUserPassword == userSettingControl1.UserPassword)
                                                            _user.Password = userSettingControl1.UserPassword;

            Data.EventHandlerUpdateUser(_user);
        }

    }
}
