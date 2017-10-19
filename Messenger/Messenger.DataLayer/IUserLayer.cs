﻿using System;
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
        User UpdateFirstName(Guid idUser, string firstName);
        User UpdateSecondName(Guid idUser, string secondName);
        User UpdatePassword(Guid idUser, string password);
        User UpdatePhoto(Guid idUser, byte[] photo);
    }
}
