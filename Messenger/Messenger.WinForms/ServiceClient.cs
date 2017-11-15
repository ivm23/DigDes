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
            using (var response = _client.PostAsJsonAsync("user", user).Result)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    user = response.Content.ReadAsAsync<User>().Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                return user;
            }
        }

        public void DelUser(Guid UserId)
        {
            _client.DeleteAsync("user/" + Convert.ToString(UserId));
        }

        
        public User GetUser(Guid id)
        {
            using (var response = _client.GetAsync("user/" + Convert.ToString(id)).Result) {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var user = response.Content.ReadAsAsync<User>().Result;
                    return user;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public List<User> GetAllUsers(Guid id)
        {
            var users = _client.GetAsync($"user/{id}/all").Result.Content.ReadAsAsync<List<User>>().Result;
            return users;
        }

        public IEnumerable<Chat> GetUserChats(Guid id)
        {
            IEnumerable<Chat> chats = null;
            using (var response = _client.GetAsync($"member/{id}/chats").Result)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    chats = response.Content.ReadAsAsync<IEnumerable<Chat>>().Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return chats;
        }

        public struct newData
        {
            public string login { get; set; }
            public string firstName { get; set; }
            public string secondName { get; set; }
            public string password { get; set; }
            public byte[] photo { get; set; }
        }
        public User UpdateUser(User user)
        {
            var data = new newData
            {
                login = user.Login,
                firstName = user.FirstName,
                secondName = user.SecondName,
                password = user.Password,
                photo = user.Photo
            };
            user = _client.PutAsJsonAsync("user/" + Convert.ToString(user.Id), data).Result.Content.ReadAsAsync<User>().Result;

            return user;

        }
        public List<Chat> GetChatsOfUser(User user)
        {
            var chats = _client.GetAsync($"member/{user.Id}/chats").Result.Content.ReadAsAsync<List<Chat>>().Result;
            return chats;
        }

        public Guid GetId(string login)
        {
            return _client.GetAsync($"user/login/{login}").Result.Content.ReadAsAsync<Guid>().Result;
        }

        //chat

        public Chat CreateChat(CreateChatData chat)
        {
            var newChat = _client.PostAsJsonAsync("chat", chat).Result.Content.ReadAsAsync<Chat>().Result;
            return newChat;
        }

        //message
        public Message CreateMessage(Message message)
        {
            message = _client.PostAsJsonAsync("message", message).Result.Content.ReadAsAsync<Message>().Result;
            return message;
        }
        public List<Message> GetChatMessages(Chat chat)
        {
            var messages = _client.GetAsync($"chat/{chat.Id}/messages").Result.Content.ReadAsAsync<List<Message>>().Result;
            return messages;
        }


    }
}
