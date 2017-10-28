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
    public class MessageController : ApiController
    {
        private readonly IMessageLayer _messageLayer;
        private const string ConnectionString = @"Data Source = (local)\SQLEXPRESS;
                                                    Initial Catalog = Messenger.BD;
                                                    Integrated Security = True";

        public MessageController()
        {
            _messageLayer = new MessageLayer(ConnectionString);
        }

        [HttpGet]
        [Route("api/message/{id}")]
        public Message Get(Guid id)
        {
            NLogger.Logger.Trace("Запрос на сообщение с ID:{0}", id);
            try
            {
                var message = _messageLayer.Get(id);
                NLogger.Logger.Trace("Получено сообщение с ID:{0}", id);
                return message;
            }
            catch
            {
                NLogMessageNotFound(id);
                throw new HttpResponseException(MessageNotFound());
            }
        }

        [HttpPost]
        [Route("api/message")]
        public Message Create([FromBody] Message message)
        {
            NLogger.Logger.Trace("Запрос на создание нового сообщения IdChat:{0}, IdUser:{1}, TimeCreate:{2}, IdAttach: {3}, text: {4}", message.IdChat, message.IdUser, message.TimeCreate, message.IdAttach, message.Text);
            var newMessage = _messageLayer.Create(message);
            NLogger.Logger.Trace("Создано новое сообщение IdMessage: {0}, IdChat:{1}, IdUser:{2}, TimeCreate:{3}, IdAttach: {4}, text: {5}", newMessage.Id, newMessage.IdChat, newMessage.IdUser, newMessage.TimeCreate, newMessage.IdAttach, newMessage.Text);
            return newMessage;
        }

        [HttpDelete]
        [Route("api/message/{id}")]
        public void Delete(Guid id)
        {
            NLogger.Logger.Trace("Запрос на удаление сообщения с Id:{0}", id);
            try
            {
                _messageLayer.Get(id);
                _messageLayer.SelfDestroy(id);
                NLogger.Logger.Trace("Сообщение с Id:{0} удалено", id);
            }
            catch
            {
                NLogMessageNotFound(id);
                throw new HttpResponseException(MessageNotFound());
            }
        }

        public struct newText
        {
            public string text { get; set; }
        }

        [HttpPut]
        [Route("api/message/{id}")]
        public Message UpdateMessage(Guid id, [FromBody]newText update)
        {
            NLogger.Logger.Trace("Запрос на обновление сообщения с Id:{0}", id);
            var message = _messageLayer.UpdateText(id, update.text); ;
            NLogger.Logger.Trace("Обновленное сообщение с id: {0}, text: {1}", id, update.text);

            return message;
        }
        public HttpResponseMessage MessageNotFound()
        {
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Такого сообщения не существует!");
        }

        public void NLogMessageNotFound(Guid id)
        {
            NLogger.Logger.Error("Сообщения с таким ChatID: {0} не существует", id);
        }
    }
}
