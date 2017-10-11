using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Messenger.Model;

namespace Messenger.DataLayer.Sql.Tests
{
    class ChatLayerTests
    {
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";

        private readonly List<Guid> _tempUsers = new List<Guid>();

        [TestMethod]
        public void ShouldStartChatWithUser()
        {
            var user = new User
            {
                FirstName = "fName",
                SecondName = "sName",
                Photo = Encoding.UTF8.GetBytes("aphoto"),
                Password = "apassword",
                TimeOfDelMes = Convert.ToDateTime("00:09:24")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);

            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);

            var userChats = chatLayer.GetUserChats(user.Id);

            Assert.AreEqual(nameOfChat, chat.NameOfChat);
            Assert.AreEqual(user.Id, chat.Members.Single().Id); // Single() - будет исключение, если больше одного пользователя с таким Id
            Assert.AreEqual(chat.Id, userChats.Single().Id);
            Assert.AreEqual(chat.NameOfChat, userChats.Single().NameOfChat);

        }

        [TestCleanup]
        public void Clean()
        {
            var userLayer = new UserLayer(ConnectionString);
            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            foreach (var id in _tempUsers)
            {
                chatLayer.Delete(id);
                userLayer.Delete(id);
            }
        }
    }
}
