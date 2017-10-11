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
            var chatMembers = chatLayer.GetChatMembers(chat.Id);

            Assert.AreEqual(nameOfChat, chat.NameOfChat);
            Assert.AreEqual(user.Id, chat.Members.Single().Id); // Single() - будет исключение, если больше одного пользователя с таким Id
            Assert.AreEqual(chat.Id, userChats.Single().Id);
            Assert.AreEqual(chat.NameOfChat, userChats.Single().NameOfChat);

            Assert.AreEqual(user.FirstName, chatMembers.ElementAt(0).FirstName);
            Assert.AreEqual(user.SecondName, chatMembers.ElementAt(0).SecondName);
            Assert.AreEqual(user.Password, chatMembers.ElementAt(0).Password);
            Assert.AreEqual(user.TimeOfDelMes, chatMembers.ElementAt(0).TimeOfDelMes);

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
                TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);
            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);

            var chatMembers = chatLayer.GetChatMembers(chat.Id);
            chat = chatLayer.Get(chat.Id);

            _tempUsers.Add(result.Id);

            Assert.AreEqual(nameOfChat, chat.NameOfChat);

            Assert.AreEqual(chatMembers.ElementAt(0).FirstName, user.FirstName);
            Assert.AreEqual(chatMembers.ElementAt(0).Password, user.Password);

            Assert.AreEqual(chatMembers.ElementAt(0).SecondName, user.SecondName);
            Assert.AreEqual(chatMembers.ElementAt(0).TimeOfDelMes, user.TimeOfDelMes);


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
                TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            const string nameOfChat = "chat";

            var userLayer = new UserLayer(ConnectionString);
            var result = userLayer.Create(user);

            _tempUsers.Add(result.Id);

            var chatLayer = new ChatLayer(ConnectionString, userLayer);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
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
        [TestCleanup]
        public void Clean()
        {
            var userLayer = new UserLayer(ConnectionString);

            foreach (var id in _tempUsers)
            {
                userLayer.Delete(id);
            }
        }

    }
}
