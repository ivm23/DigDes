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
            return _chatLayer.Get(id);
        }

        [HttpGet]
        [Route("api/chat/{id}/members")]
        public IEnumerable<User> GetMembers(Guid id)
        {
            return _chatLayer.GetChatMembers(id);
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
            return _chatLayer.Create(chat.members, chat.nameChat);
        }

        [HttpDelete]
        [Route("api/chat/{id}")]
        public void Delete(Guid id)
        {
            _chatLayer.Delete(id);
        }

        public struct newName
        {
            public string name;
        }

        [HttpPut]
        [Route("api/chat/{id}")]
        public Chat UpdateChat(Guid id, [FromBody]newName update)
        {
            return _chatLayer.UpdateName(id, update.name);
        }

    }
}
