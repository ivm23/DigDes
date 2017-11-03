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
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        public string UserName
        {
            set { userInterfaceControl1.UserName = value; }
        }

        public byte[] UserPhoto
        {
            set { userInterfaceControl1.UserPhoto = value; }
        }
    }
}
