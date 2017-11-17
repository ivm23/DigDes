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
        public Guid IdChat { get; set; }
        public Guid IdUser { get; set; }
        public string Text { get; set; }
        public Guid IdAttach { get; set; }
        public List<byte[]> Attach { get; set; }
        public DateTime TimeCreate { get; set; }
        public Boolean AlreadyRead { get; set; }
    }
}
