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
    public partial class UserCheckInControl : UserControl
    {
        public UserCheckInControl()
        {
            InitializeComponent();
        }
        public byte[] bmp_for_draw;
        public byte[] b = new byte[5000];
        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bmp = (Bitmap)Bitmap.FromFile(open_dialog.FileName);

                    var s = bmp.Size;
                    s.Width = 88;
                    s.Height = 122;
                    var temp = new Bitmap(Image.FromFile(open_dialog.FileName), s);


                    ImageConverter converter = new ImageConverter();
                    bmp_for_draw = (byte[])converter.ConvertTo(temp, typeof(byte[]));

                  
                    for (int i = 0; i < 5000 && i < bmp_for_draw.Length; ++i) b[i] = bmp_for_draw[i];

                    var imageConverter = new ImageConverter();
                    var image = (Image)imageConverter.ConvertFrom(b);

                    pbUserPhoto.Image = (Bitmap)image;
                    pbUserPhoto.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Impossible to open selected file",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        public byte[] UserPhoto
        {
            get { return bmp_for_draw; }
        }
        public string UserLogin
        {
            get { return txtUserLogin.Text;  }
        }

        public DateTime UserTimeDelMes
        {
            get { return Convert.ToDateTime(txtUserTimeDelMes.Text); }
        }

    }
}
