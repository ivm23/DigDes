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
            Data.EventHandlerDelUser = new Data.MyEventDelUser(DelUser);
            Data.EventHandlerUpdateUser = new Data.MyEventUpdateUser(UpdateUser);
        }

        void DelUser(User param)
        {
            _serviceClient.DelUser(param.Id);
            MessageBox.Show("Пользователь удален!");
        }

        void UpdateUser(User param)
        {
            _serviceClient.UpdateUser(param);
            MessageBox.Show($"Пользователь: {param.FirstName} изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMainEnter_Click(object sender, EventArgs e)
        {
            using (var form = new UserEnter())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }
     

        private void UserInterface(User user)
        {
            using (var form = new UserInterface(user)) //new MyDelegate.DelUser(DelUser), user))
            {
                form.UserName = user.FirstName + ' ' + user.SecondName;
                form.UserPhoto = user.Photo;
                if (form.ShowDialog() == DialogResult.Abort) MessageBox.Show("sdfgF");
            }

        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            byte[] ph = new byte[] { 1, 2, 3 };
            using (var form = new UserCheckIn())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                   var _user = _serviceClient.CreateUser(new User
                    {
                        FirstName = form.UserFirstName,
                        SecondName = form.UserSecondName,
                        Password = form.UserPassword,
                        Photo = form.UserPhoto,
                        TimeOfDelMes = form.UserTimeDelMes
                    });
                 
                    var message = "Пользователь" + _user.FirstName + ' ' + _user.SecondName + " успешно зарегистрирован!";
                    MessageBox.Show(message, "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    UserInterface(_user);
                }

            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            _serviceClient = new ServiceClient("http://localhost:57893/api/");
        }
    }
}
