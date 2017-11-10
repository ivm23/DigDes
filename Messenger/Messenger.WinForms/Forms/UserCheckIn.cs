using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger.WinForms.Forms
{
    public partial class UserCheckIn : Form
    {
        public UserCheckIn()
        {
            InitializeComponent();
        }

        public string UserFirstName
        {
            get { return userCheckInControl1.UserFirstName; }
        }

        public string UserSecondName
        {
            get { return userCheckInControl1.UserSecondName; }
        }

        public string UserPassword
        {
            get { return userCheckInControl1.UserPassword; }
        }

        public byte[] UserPhoto
        {
            get { return userCheckInControl1.UserPhoto; }
        }

        public DateTime UserTimeDelMes
        {
            get { return userCheckInControl1.UserTimeDelMes; }
        }

        public String UserLogin
        {
            get { return userCheckInControl1.UserLogin;  }
        }
    }
}
