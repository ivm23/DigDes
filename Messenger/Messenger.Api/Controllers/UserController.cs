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
            return _userLayer.Get(id);
        }

        [HttpPost]
        [Route("api/user")]
        public User Create([FromBody] User user)
        {
            return _userLayer.Create(user);
        }

        [HttpDelete]
        [Route("api/user/{id}")]
        public void Delete(Guid id)
        {
            _userLayer.Delete(id);

            _userLayer.Get(id);
        }
    }
}
