using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Model;

namespace Messenger.DataLayer
{
    public interface IMessageLayer
    {
        Message Create(Message message);
        Message Get(Guid idMes);
        List<byte[]> GetAttach(Guid idAttach);
        void SelfDestroy(Guid idMes);
    }
}
