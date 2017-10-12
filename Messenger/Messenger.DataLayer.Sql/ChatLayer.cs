using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.DataLayer;
using Messenger.Model;
using System.Data.SqlClient;

namespace Messenger.DataLayer.Sql
{
    public class ChatLayer : IChatLayer
    {
        private readonly string _connectionString;
        private readonly IUserLayer _userLayer;

        public ChatLayer(string connectionString, IUserLayer userLayer)
        {
            _connectionString = connectionString;
            _userLayer = userLayer;
        }

        public Chat Create(IEnumerable<Guid> members, string nameOfChat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var chat = new Chat
                    {
                        NameOfChat = nameOfChat,
                        Id = Guid.NewGuid()
                    };
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = @"insert into Chat (id, nameOfChat) 
                                                        values (@id, @nameOfChat)";

                        command.Parameters.AddWithValue("@id", chat.Id);
                        command.Parameters.AddWithValue("@nameOfChat", chat.NameOfChat);

                        command.ExecuteNonQuery();
                    }
                    foreach (var IdUser in members)
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = "insert into ChatMembers (IdChat, IdUser) values (@IdChat, @IdUser)";
                            command.Parameters.AddWithValue("@IdChat", chat.Id);
                            command.Parameters.AddWithValue("@IdUser", IdUser);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    chat.Members = members.Select(x => _userLayer.Get(x));
                    
                    return chat;
                }

            }
        }

        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from Chat where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();  
                }
            }
        }

        public IEnumerable<User> GetChatMembers(Guid IdChat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select id, password, photo, firstName, secondName, timeOfDelMes from ChatMembers 
                                                   inner join ListOfUsers on ChatMembers.IdUser = ListOfUsers.id where IdChat = @IdChat";


                    command.Parameters.AddWithValue("@IdChat", IdChat);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new User                // yield - создает итератор
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                Photo = reader.GetSqlBinary(reader.GetOrdinal("photo")).Value,
                                FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                                SecondName = reader.GetString(reader.GetOrdinal("secondName")),
                                TimeOfDelMes = reader.GetDateTime(reader.GetOrdinal("timeOfDelMes"))
                            };
                        }
                    }

                }
            }
        }

        public Chat Get(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select top(1) id, nameOfChat from Chat where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Чата с таким id {id} нет!");
                        }
             
                        return new Chat
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("id")),
                            NameOfChat = reader.GetString(reader.GetOrdinal("nameOfChat")),
                            Members = GetChatMembers(reader.GetGuid(reader.GetOrdinal("id")))
                        };

                    }

                }
            }
        }

        public IEnumerable<Chat> GetUserChats(Guid IdUser)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select id, nameOfChat from ChatMembers join Chat 
                                                   on ChatMembers.IdChat = chat.id where IdUser = @IdUser";


                    command.Parameters.AddWithValue("@IdUser", IdUser);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Chat                // yield - создает итератор
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                NameOfChat = reader.GetString(reader.GetOrdinal("nameOfChat")),
                                Members = GetChatMembers(reader.GetGuid(reader.GetOrdinal("id")))
                            };
                        }
                    }

                }
            }
        }
    }
}
