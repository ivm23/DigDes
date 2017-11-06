using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Messenger.Model;

namespace Messenger.WinForms
{

    internal class ServiceClient
    {
        private readonly HttpClient _client;

        public ServiceClient(string connectionString)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(connectionString);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public User CreateUser(User user)
        {
            user = _client.PostAsJsonAsync("user", user).Result.Content.ReadAsAsync<User>().Result;
            return user;
        }

        public void DelUser(Guid UserId)
        {
            _client.DeleteAsync("user/" + Convert.ToString(UserId));
        }

        public User GetUser(Guid id)
        {
            var user = _client.GetAsync("user/" + Convert.ToString(id)).Result.Content.ReadAsAsync<User>().Result;
            return user;
        }

        public struct newData
        {
            public string firstName { get; set; }
            public string secondName { get; set; }
            public string password { get; set; }
            public byte[] photo { get; set; }
        }
        public User UpdateUser(User user)
        {
            var data = new newData
            {
                firstName = user.FirstName,
                secondName = user.SecondName,
                password = user.Password,
                photo  = user.Photo
            };
            user = _client.PutAsJsonAsync("user/" + Convert.ToString(user.Id), data).Result.Content.ReadAsAsync<User>().Result;

            return user;

        }

    }
}
