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
    public partial class UserInterface : Form
    {
        User _user;
        public UserInterface(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public string UserName
        {
            set { userInterfaceControl1.UserName = value; }
        }

        public byte[] UserPhoto
        {
            set { userInterfaceControl1.UserPhoto = value; }
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            using (var form = new UserSetting(_user))
            {
                this.Visible = false;
                
                form.UserFirstName = _user.FirstName;
                form.UserSecondName = _user.SecondName;
                form.UserLogin = _user.Login;
                form.FormClosed += UserSetting_Closed;
                form.ShowDialog();                
            }
        }

        private void btnUserDialogs_Click(object sender, EventArgs e)
        {
            
                Data.EventHandlerChatsOfUser(_user);  
        }

        private void UserSetting_Closed(object sender, FormClosedEventArgs e)
        {
            UserName = (_user.FirstName + ' ' + _user.SecondName);
           this.Visible = true;
        }

    }
}
