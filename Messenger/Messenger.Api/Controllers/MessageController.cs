using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Messenger.DataLayer;
using Messenger.DataLayer.Sql;
using Messenger.Model;


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
            return _messageLayer.Get(id);
        }

        [HttpPost]
        [Route("api/message")]
        public Message Create([FromBody] Message message)
        {
            return _messageLayer.Create(message);
        }

        [HttpDelete]
        [Route("api/message/{id}")]
        public void Delete(Guid id)
        {
            _messageLayer.SelfDestroy(id);
        }

        public struct newText
        {
            public string text { get; set; }
        }

        [HttpPut]
        [Route("api/message/{id}")]
        public Message UpdateMessage(Guid id, [FromBody]newText update)
        {
            return _messageLayer.UpdateText(id, update.text);
        }
    }
}
