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
    public partial class UserInterfaceControl : UserControl
    {
        public UserInterfaceControl()
        {
            InitializeComponent();
        }

    public string UserName
        {
            set { lbUserName.Text = value; }
        }

    public byte[] UserPhoto
        {
            set
            {
                var imageConverter = new ImageConverter();
                var image = (Image)imageConverter.ConvertFrom(value);

                pbUserPhoto.Image = (Bitmap)image;
                pbUserPhoto.Invalidate();
            }
        }
    }
}
