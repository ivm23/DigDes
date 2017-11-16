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
    public partial class MessagesInterface : Form
    {
        public MessagesInterface()
        {
            InitializeComponent();
        }

        public List<String> SetText
        {
            set
            {
                foreach (var text in value) {
                    lbMessages.Items.Add(text);
                        }
                lbMessages.SelectedIndex = 0;                
            }
        }
    }
}
