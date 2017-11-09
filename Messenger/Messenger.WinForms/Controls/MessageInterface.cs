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
    public partial class MessageInterface : UserControl
    {
        public MessageInterface(string s)
        {
            InitializeComponent();
        }

        public List<String> SetMessages
        {
            set
            {
                lbMessages.Items.Add(value[0]);
            }
        }
    }
}
