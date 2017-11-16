using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Messenger.Model;


namespace Messenger.DataLayer.Sql.Tests
{
    public class Pair<T, K>
    {
        public T First { get; set; }
        public K Second { get; set; }
    }

    [TestClass]
    public class MessageLayerTest
    {
        Pair<User, Chat> makeEnv()
        {
             User user = new User
             { 
                FirstName = "firstName",
                SecondName = "secondName",
                Photo = Encoding.UTF8.GetBytes("photo"),
                Password = "password"
            };
            var layerUser = new UserLayer(ConnectionString);
            var resultUser = layerUser.Create(user);
            _tempUsers.Add(resultUser.Id);

            const string nameOfChat = "chat";

            var chatLayer = new ChatLayer(ConnectionString, layerUser);
            var chat = chatLayer.Create(new[] { user.Id }, nameOfChat);
            _tempChats.Add(chat.Id);
            Pair<User, Chat> result = new Pair<User, Chat>();
            result.First = user;
            result.Second = chat;
            return result;
        }

        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";
        private readonly List<Guid> _tempUsers = new List<Guid>();
        private readonly List<Guid> _tempChats = new List<Guid>();

        [TestMethod]
        public void ShouldCreateMessage()
        {
            byte[] data = Encoding.UTF8.GetBytes("ololol");
            List<byte[]> attach = new List<byte[]>();
            attach.Add(data);

            var env = makeEnv();

            var message = new Message
            {
                IdChat = env.Second.Id,
                IdUser = env.First.Id,
                Text = "bla-bla-bla",
                Attach = attach,
                TimeCreate = Convert.ToDateTime("09:24:45")
            };

            var layer = new MessageLayer(ConnectionString);
            var result = layer.Create(message);

            Assert.AreEqual(result.Id, message.Id);
            Assert.AreEqual(result.IdChat, message.IdChat);
            Assert.AreEqual(result.IdUser, message.IdUser);
            Assert.AreEqual(result.Text, message.Text);
            Assert.AreEqual(result.IdAttach, message.IdAttach);
            Assert.AreEqual(result.TimeCreate, message.TimeCreate);
        }


        [TestMethod]
        public void ShouldSelfDestroyMessage()
        {
            byte[] data = Encoding.UTF8.GetBytes("ololol");
            List<byte[]> attach = new List<byte[]>();
            attach.Add(data);

            var env = makeEnv();

            var message = new Message
            {
                IdChat = env.Second.Id,
                IdUser = env.First.Id,
                Text = "bla-bla-bla",
                Attach = attach,
                TimeCreate = Convert.ToDateTime("09:24:45")
            };

            var layer = new MessageLayer(ConnectionString);
            var result = layer.Create(message);
            layer.SelfDestroy(message.Id);

            try
            {
                result = layer.Get(message.Id);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, $"Сообщения с таким id {message.Id} нет!");
            }

        }


        [TestMethod]
        public void ShouldGetMessage()
        {
            byte[] data = Encoding.UTF8.GetBytes("ololol");
            List<byte[]> attach = new List<byte[]>();
            attach.Add(data);

            var env = makeEnv();

            var message = new Message
            {
                IdChat = env.Second.Id,
                IdUser = env.First.Id,
                Text = "bla-bla-bla",
                Attach = attach,
                TimeCreate = Convert.ToDateTime("09:24:45")
            };

            var layer = new MessageLayer(ConnectionString);
            var result = layer.Create(message);
            result = layer.Get(message.Id);

            Assert.AreEqual(result.Id, message.Id);
            Assert.AreEqual(result.IdChat, message.IdChat);
            Assert.AreEqual(result.IdUser, message.IdUser);
            Assert.AreEqual(result.IdAttach, message.IdAttach);
            Assert.AreEqual(result.Text, message.Text);
            Assert.AreEqual(result.TimeCreate, message.TimeCreate);
        }

        [TestMethod]
        public void ShouldUpdateMessage()
        {
            byte[] data = Encoding.UTF8.GetBytes("ololol");
            List<byte[]> attach = new List<byte[]>();
            attach.Add(data);

            var env = makeEnv();

            var message = new Message
            {
                IdChat = env.Second.Id,
                IdUser = env.First.Id,
                Text = "bla-bla-bla",
                Attach = attach,
                TimeCreate = Convert.ToDateTime("09:24:45")
            };

            var layer = new MessageLayer(ConnectionString);
            var result = layer.Create(message);

            var resultUpdate = layer.UpdateText(message.Id, "dfsdsgdfgdfg");
            result = layer.Get(message.Id);


            Assert.AreEqual(result.Id, resultUpdate.Id);
            Assert.AreEqual(result.IdChat, resultUpdate.IdChat);
            Assert.AreEqual(result.IdUser, resultUpdate.IdUser);
            Assert.AreEqual(result.Text, resultUpdate.Text);
            Assert.AreEqual(result.IdAttach, resultUpdate.IdAttach);
            Assert.AreEqual(result.TimeCreate, resultUpdate.TimeCreate);
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
