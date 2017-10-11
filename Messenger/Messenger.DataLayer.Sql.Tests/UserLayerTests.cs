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
    public class UserLayerTests
    {
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";

        private readonly List<Guid> _tempUsers = new List<Guid>();

        [TestMethod]
        public void ShouldCreateUser()
        {
            var user = new User
            {
                FirstName = "firstName",
                SecondName = "secondName",
                Photo = Encoding.UTF8.GetBytes("photo"),
                Password = "password",
                TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            var layer = new UserLayer(ConnectionString);
            var result = layer.Create(user);

            _tempUsers.Add(result.Id);


            Assert.AreEqual(user.Photo, result.Photo);
            Assert.AreEqual(user.FirstName, result.FirstName);
            Assert.AreEqual(user.SecondName, result.SecondName);
            Assert.AreEqual(user.Password, result.Password);
            Assert.AreEqual(user.TimeOfDelMes, result.TimeOfDelMes);
        }

        [TestMethod]
        public void ShouldGetUser()
        {
            var user = new User
            {
                FirstName = "firstName",
                SecondName = "secondName",
                Photo = Encoding.UTF8.GetBytes("photo"),
                Password = "password",
                TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            var layer = new UserLayer(ConnectionString);
            var result = layer.Create(user);
            result = layer.Get(user.Id);

            _tempUsers.Add(result.Id);

           // Assert.AreEqual(user.Photo, result.Photo);
            Assert.AreEqual(user.FirstName, result.FirstName);
            Assert.AreEqual(user.SecondName, result.SecondName);
            Assert.AreEqual(user.Password, result.Password);
            Assert.AreEqual(user.TimeOfDelMes, result.TimeOfDelMes);
        }


        [TestMethod]
        public void ShouldDeleteUser()
        {
            var user = new User
            {
                FirstName = "firstName",
                SecondName = "secondName",
                Photo = Encoding.UTF8.GetBytes("photo"),
                Password = "password",
                TimeOfDelMes = Convert.ToDateTime("00:09:23")
            };

            var layer = new UserLayer(ConnectionString);
            var result = layer.Create(user);
            layer.Delete(user.Id);
            try {
                result = layer.Get(user.Id);
            }
            catch(ArgumentException e)
            {
                Assert.AreEqual(e.Message, $"Пользователя с таким id {user.Id} нет!");
            }
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
