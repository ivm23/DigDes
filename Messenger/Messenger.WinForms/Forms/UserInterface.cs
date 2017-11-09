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
                if (form.ShowDialog() == DialogResult.Abort)
                    MessageBox.Show("UserInterface");
                
            }
        }

        private void btnUserDialogs_Click(object sender, EventArgs e)
        {
           
                Data.EventHandlerChatsOfUser(_user);
            //    if (form.ShowDialog() == DialogResult.Abort)
              //      MessageBox.Show("UserInterface");
            
        }
    }
}
