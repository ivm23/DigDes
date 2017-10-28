using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Messenger.DataLayer;
using Messenger.DataLayer.Sql;
using Messenger.Model;
using Messenger.Logger;

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
            catch {
                NLogUserNotFound(id);
                throw new HttpResponseException(UserNotFound());
            }
        }

        [HttpPost]
        [Route("api/user")]
        public User Create([FromBody] User user)
        {
            NLogger.Logger.Trace("Запрос на создание нового пользователя FirstName: {0}, SecondName: {1},  Password: {3}", user.FirstName, user.SecondName,  user.Password);
            if (user.Password == null)
            {
                NLogger.Logger.Error(
                    "Пользователь не ввел пароль! UserID: {0}", user.Id);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Не введен пароль!"));
            }

            var newUser = _userLayer.Create(user);
            NLogger.Logger.Trace("Создан новый пользователь id: {0}, FirstName: {1}, SecondName: {2}, Password: {3})", newUser.Id, newUser.SecondName, newUser.FirstName, newUser.Password);
            return newUser;
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
            public string firstName { get; set;  }
            public string secondName { get; set;  }
            public string password { get; set; }
            public byte[] photo { get; set; }
        }

        [HttpPut]
        [Route("api/user/{id}")]
        public User UpdateUser(Guid id, [FromBody]newData update) 
        {
            NLogger.Logger.Trace("Запрос на обновление пользователя с Id:{0}", id);
            try
            {
                _userLayer.Get(id);
                _userLayer.UpdateFirstName(id, update.firstName);
                _userLayer.UpdateSecondName(id, update.secondName);
                _userLayer.UpdatePassword(id, update.password);
                _userLayer.UpdatePhoto(id, update.photo);
                var user = _userLayer.Get(id);
                NLogger.Logger.Trace("Обновленный пользователь с id: {0}, FirstName: {1}, SecondName: {2}, Password: {3}", user.Id, user.SecondName, user.FirstName, user.Password);
                return user;
            }
            catch
            {
                NLogUserNotFound(id);
                throw new HttpResponseException(UserNotFound());
            }
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
