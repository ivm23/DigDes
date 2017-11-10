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
    public partial class UserAuthorizationControl : UserControl
    {
        public UserAuthorizationControl()
        {
            InitializeComponent();
        }

        public string UserLogin
        {
            get { return txtLogin.Text; }
        }

        public string UserPassword
        {
            get { return txtPassword.Text; }
        }

    }
}
