using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Model
{
    public class Message
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public byte[] Attach { get; set; }
        public bool SelfDestroy { get; set; }
        public DateTime TimeCreate { get; set; }
    }
}
