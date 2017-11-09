using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Model;

namespace Messenger.DataLayer
{
    
    public interface IChatLayer
    {
        Chat Create(IEnumerable<Guid> members, string nameOfChat);
        void Delete(Guid IdChat);
        Chat Get(Guid IdChat);
        IEnumerable<User> GetChatMembers(Guid IdChat);
        IEnumerable<Chat> GetUserChats(Guid IdUser);
        IEnumerable<Message> GetChatMessages(Guid idChat);

        Chat UpdateName(Guid id, string nameChat);
        Chat AddUser(Guid idChat, List<Guid> idUser);
        void DeleteUser(Guid idChat, Guid idUser);
    }
}
