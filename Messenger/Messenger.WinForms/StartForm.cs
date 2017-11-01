using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.WinForms.Forms;
using Messenger.Model;

namespace Messenger.WinForms
{
    public partial class StartForm : Form
    {
        private ServiceClient _serviceClient;

        public StartForm()
        {
            InitializeComponent();
        }


  

        private void btnMainEnter_Click(object sender, EventArgs e)
        {
            using (var form = new UserEnter())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //var user = _serviceClient.CreateUser(new User { FirstName = form.UserName });
                    ///MessageBox.Show($"Id пользователя: {user.Id}", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            byte[] ph = new byte[3] { 1,2,3};
            using (var form = new UserCheckIn())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                    var user = _serviceClient.CreateUser(new User
                    {
                        FirstName = form.UserFirstName,
                        SecondName = form.UserSecondName,
                        Password = form.UserPassword,
                        Photo = ph,
                        TimeOfDelMes = form.UserTimeDelMes
                                                                 });
                    MessageBox.Show($"Пользователь: {user.FirstName} успешно зарегистрирован!", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            _serviceClient = new ServiceClient("http://localhost:57893/api/");
        }
    }
}
