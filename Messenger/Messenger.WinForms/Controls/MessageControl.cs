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
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public List<String> SetChatMessages
        {

            set
            {
                Controls.Clear();

                var mes = new MessageControl();
                foreach (var text in value)
                {
                    mes.lbMessage.Items.Add(text);
                }

                Controls.Add(mes);
            }
        }
    }
}
