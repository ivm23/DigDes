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
    public partial class ChatMessagesControl : UserControl
    {
        
        public ChatMessagesControl(List<String> s)
        {
            InitializeComponent(s);
        }

        public List<String> SetText
        {
            set {
                Controls.Clear();
                
                var mes = new ChatMessagesControl(value);
               
                Controls.Add(mes);
            }
        }
    }
}
