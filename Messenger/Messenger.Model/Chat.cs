﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Model
{
    public class Chat
    {
        public Guid Id { get; set; }
        public string NameOfChat { get; set; }
        public IEnumerable<User> Members { get; set; }
    }
}
