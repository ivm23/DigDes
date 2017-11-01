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
        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var temp = new Bitmap(open_dialog.FileName);

                    ImageConverter converter = new ImageConverter();
                    bmp_for_draw = (byte[])converter.ConvertTo(temp, typeof(byte[]));

                    //pictureBox1.ClientSize = new Size(bmp_for_draw.Width, bmp_for_draw.Height);
                    //pictureBox1.Image = bmp_for_draw;
                    //pictureBox1.Invalidate();
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
            get
            {
                return txtUserFirstName.Text;
            }
        }

        public string UserSecondName
        {
            get
            {
                return txtUserSecondName.Text;
            }
        }

        public string UserPassword
        {
            get
            {
                return txtUserPassword.Text;
            }
        }

        public byte[] UserPhoto
        {
            get
            {
                return bmp_for_draw ;
            }
        }

        public DateTime UserTimeDelMes
        {
            get
            {
                return Convert.ToDateTime("00:00:00");
            }
        }

    }
}
