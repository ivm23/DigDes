using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public byte[] Photo { get; set; }
        public string Password { get; set; }
        public DateTime TimeOfDelMes { get; set; }
    }
}
