using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Model;

namespace Messenger.DataLayer
{
    public interface IUserLayer
    {
        User Create(User user);
        void Delete(Guid idUser);
        User Get(Guid idUser);
    }
}
