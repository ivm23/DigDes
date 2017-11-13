using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Messenger.DataLayer;
using Messenger.DataLayer.Sql;
using Messenger.Model;
using Messenger.Logger;
using System.Collections.Generic;

namespace Messenger.Api.Controllers
{
    public class UserController : ApiController
    {

        private readonly IUserLayer _userLayer;
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";

        public UserController()
        {
            _userLayer = new UserLayer(ConnectionString);
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public User Get(Guid id)
        {
            NLogger.Logger.Trace("Запрос на пользователя с ID:{0}", id);
            try
            {
                var user = _userLayer.Get(id);
                NLogger.Logger.Trace("Получен пользователь с ID:{0}", id);

                return user;
            }
            catch
            {
                NLogUserNotFound(id);
                throw new HttpResponseException(UserNotFound());
            }
        }


        [HttpGet]
        [Route("api/user/login/{login}")]
        public Guid GetId(string login)
        {
            NLogger.Logger.Trace("Запрос на пользователя с login:{0}", login);
            try
            {
                var id = _userLayer.GetId(login);
                NLogger.Logger.Trace("Получен пользователь с login:{0}", login);

                return id;
            }
            catch
            {
                //NLogUserNotFound();
                throw new HttpResponseException(UserNotFound());
            }
        }

        [HttpGet]
        [Route("api/user/{id}/all")]
        public List<User> GetAllUsers(Guid id)
        {
            NLogger.Logger.Trace("Запрос на пользователей");
            try
            {
                var user = _userLayer.AllUsers(id);
                NLogger.Logger.Trace("Пользователи получены");

                return user;
            }
            catch
            {
                NLogUserNotFound(id);
                throw new HttpResponseException(UserNotFound());
            }
        }

        [HttpPost]
        [Route("api/user")]
        public User Create([FromBody] User user)
        {
            NLogger.Logger.Trace("Запрос на создание нового пользователя FirstName: {0}, SecondName: {1},  Password: {3}, Login:{4}", user.FirstName, user.SecondName, user.Password, user.Login);
            if (user.Password == null)
            {
                NLogger.Logger.Error(
                    "Пользователь не ввел пароль! UserID: {0}", user.Id);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Не введен пароль!"));
            }
            try
            {
                var newUser = _userLayer.Create(user);
                NLogger.Logger.Trace("Создан новый пользователь id: {0}, FirstName: {1}, SecondName: {2}, Password: {3}, Login:{4})", newUser.Id, newUser.SecondName, newUser.FirstName, newUser.Password, user.Login);
                return newUser;
            }
            catch
            {
                throw new Exception("Такой пользователь уже существует!");
            }
        }

        [HttpDelete]
        [Route("api/user/{id}")]
        public void Delete(Guid id)
        {
            NLogger.Logger.Trace("Запрос на удаление пользователя с Id:{0}", id);
            try
            {
                _userLayer.Get(id);
                _userLayer.Delete(id);
                NLogger.Logger.Trace("Пользователь с Id:{0} удален", id);
            }
            catch
            {
                NLogUserNotFound(id);
                throw new HttpResponseException(UserNotFound());
            }

        }

        public struct newData
        {
            public string login { get; set; }
            public string firstName { get; set; }
            public string secondName { get; set; }
            public string password { get; set; }
            public byte[] photo { get; set; }
            public DateTime timeDelMes { get; set; }
        }

        [HttpPut]
        [Route("api/user/{id}")]
        public User UpdateUser(Guid id, [FromBody]newData update)
        {
            NLogger.Logger.Trace("Запрос на обновление пользователя с Id:{0}", id);
            try
            {
                _userLayer.Get(id);
            }
            catch
            {
                NLogUserNotFound(id);
                throw new HttpResponseException(UserNotFound());
            }
            try { _userLayer.UpdateLogin(id, update.login); }
            catch { }
            _userLayer.UpdateFirstName(id, update.firstName);
            _userLayer.UpdateSecondName(id, update.secondName);
            _userLayer.UpdatePassword(id, update.password);
            _userLayer.UpdatePhoto(id, update.photo);
            _userLayer.UpdateTimeDelMes(id, update.timeDelMes);
            var user = _userLayer.Get(id);
            NLogger.Logger.Trace("Обновленный пользователь с id: {0}, FirstName: {1}, SecondName: {2}, Password: {3}, TimeOfDelMes: {4}, Login: {5}", user.Id, user.SecondName, user.FirstName, user.Password, user.TimeOfDelMes, user.Login);
            return user;


        }

        public HttpResponseMessage UserNotFound()
        {
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Такого пользователя не существует!");
        }
        public void NLogUserNotFound(Guid id)
        {
            NLogger.Logger.Error("Пользователя с таким UserID: {0} не существует", id);
        }
    }
}
