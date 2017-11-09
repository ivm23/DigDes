using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Messenger.DataLayer;
using Messenger.DataLayer.Sql;
using Messenger.Model;
using Messenger.Logger;


namespace Messenger.Api.Controllers
{
    public class ChatController : ApiController
    {
        private readonly IChatLayer _chatLayer;
        private readonly IUserLayer _userLayer = new UserLayer(ConnectionString);

        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";
        public ChatController()
        {
            _chatLayer = new ChatLayer(ConnectionString, _userLayer);
        }


        [HttpGet]
        [Route("api/chat/{id}")]
        public Chat Get(Guid id)
        {
            NLogger.Logger.Trace("Запрос на чат с ID:{0}", id);
            try
            {
                var chat = _chatLayer.Get(id);
                NLogger.Logger.Trace("Получен чат с ID:{0}", id);
                return chat;
            }
            catch
            {
                NLogChatNotFound(id);
                throw new HttpResponseException(ChatNotFound());
            }
        }

        [HttpGet]
        [Route("api/chat/{id}/members")]
        public IEnumerable<User> GetMembers(Guid id)
        {
            NLogger.Logger.Trace("Запрос на пользователей чата с ID:", id);
            try
            {
                _chatLayer.Get(id);
                var members = _chatLayer.GetChatMembers(id);
                NLogger.Logger.Trace("Получены пользователи чата с ID:{0}", id);
                return members;
            }
            catch
            {
                NLogChatNotFound(id);
                throw new HttpResponseException(ChatNotFound());
            }
        }

        [HttpGet]
        [Route("api/chat/{id}/members/{idMemb}")]
        public User GetMember(Guid id, Guid idMemb)
        {
            NLogger.Logger.Trace("Запрос на пользователя с IdUser: {0} чата с ID:{1}", idMemb, id);
            try
            {
                _chatLayer.Get(id);
                var chatMembers = _chatLayer.GetChatMembers(id);
                var users = _userLayer.Get(idMemb);
                var user = (chatMembers.Any(x => x.Id == users.Id) ? users : null); ;
                NLogger.Logger.Trace("Получен пользователь с IdUser: {0} чата с ID:{1}", idMemb, id);
                return user;
            }
            catch
            {
                NLogChatNotFound(id);
                throw new HttpResponseException(ChatNotFound());
            }
        }

        [HttpGet]
        [Route("api/member/{idMemb}/chats")]
        public IEnumerable<Chat> GetChats(Guid idMemb)
        {
            NLogger.Logger.Trace("Запрос на чаты пользователя с IdUser: {0}", idMemb);
            try
            {
                var chats = _chatLayer.GetUserChats(idMemb);
               
                NLogger.Logger.Trace("Получены чаты пользователя с IdUser: {0} ", idMemb);
                return chats;
            }
            catch
            {
                NLogger.Logger.Error("Пользователя с таким UserID: {0} не существует", idMemb);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Пользователя не существует!"));                              
            }
        }

        [HttpGet]
        [Route("api/chat/{idChat}/messages")]
        public IEnumerable<Message> GetMessages(Guid idChat)
        {
            NLogger.Logger.Trace("Запрос на сообщения чата с IdChat: {0}", idChat);
            try
            {
                var messages = _chatLayer.GetChatMessages(idChat);

                NLogger.Logger.Trace("Получены сообщения чата с IdChat: {0} ", idChat);
                return messages;
            }
            catch
            {
                NLogger.Logger.Error("Чата с таким IdChat: {0} не существует", idChat);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Чата не существует!"));
            }
        }


        public struct CreateChatData
        {
            public string nameChat;
            public IEnumerable<Guid> members;
        }

        [HttpPost]
        [Route("api/chat")]
        public Chat Create([FromBody]CreateChatData chat)
        {
            NLogger.Logger.Trace("Запрос на создание нового чата nameOfChat:{1}", chat.nameChat);
            if (chat.members == null)
            {
                NLogger.Logger.Error("Нет пользователей для создания чата!");
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Нет пользователей!"));
            }
            else
            {
                var newChat = _chatLayer.Create(chat.members, chat.nameChat);
                NLogger.Logger.Trace("Создан новый чат IdChat: {0}, nameOfChat:{1}", newChat.Id, newChat.NameOfChat);
                return newChat;
            }
        }

        public struct NewUsers
        {
            public List<Guid> newUsers;
        }

        [HttpPost]
        [Route("api/chat/{id}/members/add")]
        public Chat AddUsers(Guid id, [FromBody]NewUsers users)
        {
            NLogger.Logger.Trace("Запрос на создание нового пользователя чата c ID:{1}", id);
            var newUser = _chatLayer.AddUser(id, users.newUsers);
            NLogger.Logger.Trace("Создан новый пользователь IdUser: {0} чата IdChat: {1}", newUser.Id, id);

            return newUser;
        }

        [HttpDelete]
        [Route("api/chat/{id}")]
        public void Delete(Guid id)
        {
            NLogger.Logger.Trace("Запрос на удаление чата IdChat:{0}", id);
            try
            {
                _chatLayer.Delete(id);
                NLogger.Logger.Trace("Чат IdChat:{0} удален", id);
            }
            catch
            {
                NLogChatNotFound(id);
                throw new HttpResponseException(ChatNotFound());
            }
        }

        [HttpDelete]
        [Route("api/chat/{id}/members/{idMemb}/delete")]
        public void DeleteUser(Guid id, Guid idMemb)
        {
            NLogger.Logger.Trace("Запрос на удаление пользователя IdUser: {0} из чата IdChat:{1}", idMemb, id);
            try
            {
                _chatLayer.Get(id);
                _chatLayer.DeleteUser(id, idMemb);
                NLogger.Logger.Trace("Пользователь IdUser:{0} удален из чата IdChat:{1}", idMemb, id);
            }
            catch
            {

                NLogChatNotFound(id);
                throw new HttpResponseException(ChatNotFound());
            }
            
        }

        public struct newName
        {
            public string name;
        }

        [HttpPut]
        [Route("api/chat/{id}")]
        public Chat UpdateChat(Guid id, [FromBody]newName update)
        {
            NLogger.Logger.Trace("Запрос на обновление чата с Id:{0}", id);
            try
            {
                var chat = _chatLayer.UpdateName(id, update.name);
                _chatLayer.Get(id);
                NLogger.Logger.Trace("Обновленный чат с id: {0}, nameOfChat: {1}", chat.Id, chat.NameOfChat);
                return chat;
            }
            catch
            {
                NLogChatNotFound(id);
                throw new HttpResponseException(ChatNotFound());
            }
        }

        public HttpResponseMessage ChatNotFound()
        {
            return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Такого чата не существует!");
        }

        public void NLogChatNotFound(Guid id)
        {
            NLogger.Logger.Error("Чата с таким ChatID: {0} не существует", id); 
        }

    }
}
