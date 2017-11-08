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
    public partial class AddUsersControl : UserControl
    {
        public AddUsersControl()
        {
            InitializeComponent();
        }

        public List<String> SetChatMembers
        {
            set
            {
                foreach (var val in value)
                {
                    txtChatUsers.Text += val + Environment.NewLine;
                }
            }
        }
    }
}
