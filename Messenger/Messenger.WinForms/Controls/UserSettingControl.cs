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
            get { return txtUserFirstName.Text; }
        }

        public string UserSecondName
        {
            get { return txtUserSecondName.Text; }
        }


        public string UserPassword
        {
            get { return txtUserPassword.Text; }
        }

        public string RepeatUserPassword
        {
            get { return txtRepeatUserPassword.Text; }
        }


        public DateTime UserTimeDelMes
        {
            get { return (txtUserTimeDelMes.Text != "" ? Convert.ToDateTime(txtUserTimeDelMes.Text) : 
                                                         Convert.ToDateTime("0:0:0"));  }
        }
    }
}
