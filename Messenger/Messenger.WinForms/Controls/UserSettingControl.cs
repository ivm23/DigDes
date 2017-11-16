using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger.WinForms.Controls
{
    public partial class UserSettingControl : UserControl
    {
        public UserSettingControl()
        {
            InitializeComponent();
        }
     

        public string UserFirstName
        {
            set { txtUserFirstName.Text = value; }
            get { return txtUserFirstName.Text; }
        }

        public string UserSecondName
        {
            set { txtUserSecondName.Text = value; }
            get { return txtUserSecondName.Text; }
        }


        public string UserPassword
        {
            get { return txtUserPassword.Text; }
        }

        public string UserLogin
        {
            set { txtUserLogin.Text = value; }
            get { return txtUserLogin.Text; }
        }
        public string RepeatUserPassword
        {
            get { return txtRepeatUserPassword.Text; }
        }

    }
}
