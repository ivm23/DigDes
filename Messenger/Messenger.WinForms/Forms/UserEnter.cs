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
    public partial class UserEnter : Form
    {
        public UserEnter()
        {
            InitializeComponent();
        }

        public string UserLogin
        {
            get { return userAuthorizationControl1.UserLogin; }
        }

        public string UserPassword
        {
            get { return userAuthorizationControl1.UserPassword; }
        }
    }
}
