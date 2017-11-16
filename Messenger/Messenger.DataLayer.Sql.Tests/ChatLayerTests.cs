using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Messenger.Model;

namespace Messenger.DataLayer.Sql.Tests
{
    [TestClass]
    public class ChatLayerTests
    {
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";

        private readonly List<Guid> _tempUsers = new List<Guid>();
        private readonly List<Guid> _tempChats = new List<Guid>();

        [TestMethod]
        public void ShouldStartChatWithUser()
        {
            var user = new User
            {
                FirstName = "fName",
                SecondName = "sName",
                Photo = Encoding.UTF8.GetBytes("aphoto"),
                Password = "apassword",
                //TimeOfDelMes = Convert.ToDateTime("00:09:24")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);

            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
            _tempChats.Add(chat.Id);

            var userChats = chatLayer.GetUserChats(user.Id);
            var chatMembers = chatLayer.GetChatMembers(chat.Id);

            Assert.AreEqual(nameOfChat, chat.NameOfChat);
            Assert.AreEqual(user.Id, chat.Members.Single().Id); // Single() - будет исключение, если больше одного пользователя с таким Id
            Assert.AreEqual(chat.Id, userChats.Single().Id);
            Assert.AreEqual(chat.NameOfChat, userChats.Single().NameOfChat);

            Assert.AreEqual(user.FirstName, chatMembers.ElementAt(0).FirstName);
            Assert.AreEqual(user.SecondName, chatMembers.ElementAt(0).SecondName);
            Assert.AreEqual(user.Password, chatMembers.ElementAt(0).Password);
            //Assert.AreEqual(user.TimeOfDelMes, chatMembers.ElementAt(0).TimeOfDelMes);
        }

        [TestMethod]
        public void ShouldGetChat()
        {
            var user = new User
            {
                FirstName = "firstName",
                SecondName = "secondName",
                Photo = Encoding.UTF8.GetBytes("photo"),
                Password = "password",
                //TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);
            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
            _tempChats.Add(chat.Id);

            var chatMembers = chatLayer.GetChatMembers(chat.Id);
            chat = chatLayer.Get(chat.Id);

            _tempUsers.Add(result.Id);

            Assert.AreEqual(nameOfChat, chat.NameOfChat);

            Assert.AreEqual(chat.Members.ElementAt(0).FirstName, user.FirstName);
            Assert.AreEqual(chat.Members.ElementAt(0).FirstName, user.FirstName);
            Assert.AreEqual(chat.Members.ElementAt(0).Password, user.Password);

            Assert.AreEqual(chat.Members.ElementAt(0).SecondName, user.SecondName);
            //Assert.AreEqual(chat.Members.ElementAt(0).TimeOfDelMes, user.TimeOfDelMes);
        }



        [TestMethod]
        public void ShouldDeleteChat()
        {
            var user = new User
            {
                FirstName = "firstName",
                SecondName = "secondName",
                Photo = Encoding.UTF8.GetBytes("photo"),
                Password = "password",
                //TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);

            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
            _tempChats.Add(chat.Id);
            chatLayer.Delete(chat.Id);
            try
            {
                chat = chatLayer.Get(chat.Id);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, $"Чата с таким id {chat.Id} нет!");
            }
        }

        [TestMethod]
        public void ShouldUpdateName()
        {
            var user = new User
            {
                FirstName = "fName",
                SecondName = "sName",
                Photo = Encoding.UTF8.GetBytes("aphoto"),
                Password = "apassword",
                //TimeOfDelMes = Convert.ToDateTime("00:09:24")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);

            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
            _tempChats.Add(chat.Id);

            var resultUpdate = chatLayer.UpdateName(chat.Id, "fdsgdfgfg");
            chat = chatLayer.Get(chat.Id);


            Assert.AreEqual(resultUpdate.NameOfChat, chat.NameOfChat);
            Assert.AreEqual(resultUpdate.Id, chat.Id);
        }

        [TestMethod]
        public void ShouldAddAndDeleteUser()
        {
            var user = new User
            {
                FirstName = "fName1",
                SecondName = "sName1",
                Photo = Encoding.UTF8.GetBytes("aphoto"),
                Password = "apassword1",
                //TimeOfDelMes = Convert.ToDateTime("00:09:24")
            };
            var user2 = new User
            {
                FirstName = "fName21",
                SecondName = "sNam2e1",
                Photo = Encoding.UTF8.GetBytes("aphot2o"),
                Password = "apasswo2rd1",
                //TimeOfDelMes = Convert.ToDateTime("00:09:24")
            };
            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);
            _tempUsers.Add(result.Id);
            result = userLayer.Create(user2);
            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
            _tempChats.Add(chat.Id);

            List<Guid> members = new List<Guid> { user2.Id};
            
            chat = chatLayer.AddUser(chat.Id, members);

            var userChats = chatLayer.GetUserChats(user2.Id);
            var chatMembers = chatLayer.GetChatMembers(chat.Id);

            Assert.AreEqual(nameOfChat, chat.NameOfChat);
            Assert.AreEqual(user2.Id, chat.Members.ElementAt(1).Id); // Single() - будет исключение, если больше одного пользователя с таким Id
            Assert.AreEqual(chat.Id, userChats.Single().Id);
            Assert.AreEqual(chat.NameOfChat, userChats.Single().NameOfChat);

            Assert.AreEqual(user2.FirstName, chatMembers.ElementAt(1).FirstName);
            Assert.AreEqual(user2.SecondName, chatMembers.ElementAt(1).SecondName);
            Assert.AreEqual(user2.Password, chatMembers.ElementAt(1).Password);
         //   Assert.AreEqual(user2.TimeOfDelMes, chatMembers.ElementAt(1).TimeOfDelMes);

            chatLayer.DeleteUser(chat.Id, members.ElementAt(0));
            
            chatMembers = chatLayer.GetChatMembers(chat.Id);
            bool IsUser2Id = false;
            foreach(var member in chatMembers)
            {
                if (member.Id == user2.Id) IsUser2Id = true;
            }
            Assert.AreEqual(false, IsUser2Id);
        }



        [TestCleanup]
        public void Clean()
        {
            foreach (var id in _tempUsers)
                new UserLayer(ConnectionString).Delete(id);

            foreach (var id in _tempChats)
                new ChatLayer(ConnectionString, new UserLayer(ConnectionString)).Delete(id);
        }

    }
}
