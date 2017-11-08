using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.Model;
using System.Data.SqlClient;
using Messenger.Logger;

namespace Messenger.DataLayer.Sql
{
    public class MessageLayer : IMessageLayer
    {
        private readonly string _connectionString;

        public MessageLayer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Message Create(Message message)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        if (message.Attach != null && message.Attach.Count != 0)
                        {
                            foreach (var attach in message.Attach)
                            {
                                message.Id = Guid.NewGuid();
                                message.IdAttach = Guid.NewGuid();

                                command.Transaction = transaction;
                                command.CommandText = "insert into Attach (id, AttachedFile) values (@idAt, @AttachedFile)";
                                command.Parameters.AddWithValue("@idAt", message.IdAttach);
                                command.Parameters.AddWithValue("@AttachedFile", attach);

                                command.ExecuteNonQuery();
                                command.Transaction = transaction;
                                command.CommandText = @"insert into Message (id, IdChat, IdUser, timeCreate, IdAttach, text) 
                                                        values (@id, @idChat, @idUser, @timeCreate, @idAttach, @text)";

                                command.Parameters.AddWithValue("@id", message.Id);
                                command.Parameters.AddWithValue("@idChat", message.IdChat);
                                command.Parameters.AddWithValue("@idUser", message.IdUser);
                                command.Parameters.AddWithValue("@timeCreate", message.TimeCreate);
                                command.Parameters.AddWithValue("@idAttach", message.IdAttach);
                                command.Parameters.AddWithValue("@text", message.Text);

                                command.ExecuteNonQuery();

                                NLogger.Logger.Trace("База данных: Добавлено в таблицу :{0}: значения (IdMessage: {1}, IdChat:{2}, IdUser:{3}, TimeCreate: {4}, IdAttach: {5}, text: {6})", "[ListOfUsers]", message.Id, message.IdChat, message.IdUser, message.TimeCreate, message.IdAttach, message.Text);
                            }
                        }
                        else
                        {
                            message.Id = Guid.NewGuid();
                            message.IdAttach = Guid.NewGuid();

                            command.Transaction = transaction;
                            command.CommandText = @"insert into Message (id, IdChat, IdUser, timeCreate, text) 
                                                        values (@id, @idChat, @idUser, @timeCreate,  @text)";

                            command.Parameters.AddWithValue("@id", message.Id);
                            command.Parameters.AddWithValue("@idChat", message.IdChat);
                            command.Parameters.AddWithValue("@idUser", message.IdUser);
                            command.Parameters.AddWithValue("@timeCreate", message.TimeCreate);
                            command.Parameters.AddWithValue("@text", message.Text);

                            command.ExecuteNonQuery();
                            NLogger.Logger.Trace("База данных: Добавлено в таблицу :{0}: значения (IdMessage: {1}, IdChat:{2}, IdUser:{3}, TimeCreate: {4}, IdAttach: {5}, text: {6})", "[Message]", message.Id, message.IdChat, message.IdUser, message.TimeCreate, message.IdAttach, message.Text);
                        }
                        transaction.Commit();
                        return message;
                    }
                }
            }
        }

        public List<byte[]> GetAttach(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select top(1) id, AttachedFile from Attach where id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Вложения с таким id {id} нет!");
                        }
                        List<byte[]> attach = new List<byte[]>();
                        while (reader.Read())
                        {
                            var data = reader.GetSqlBinary(reader.GetOrdinal("AttachedFile")).Value;
                            attach.Add(data);
                        }
                        return attach;
                    }
                }
            }
        }


        public Message Get(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select top(1) id, IdChat, IdUser, timeCreate, IdAttach, text 
                                                                              from Message where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Сообщения с таким id {id} нет!");
                        }

                      
                        if (!reader.IsDBNull(reader.GetOrdinal("IdAttach")))
                        {
                            return new Message
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                IdChat = reader.GetGuid(reader.GetOrdinal("IdChat")),
                                IdUser = reader.GetGuid(reader.GetOrdinal("IdUser")),
                                TimeCreate = reader.GetDateTime(reader.GetOrdinal("timeCreate")),
                                Text = reader.GetString(reader.GetOrdinal("text")),
                                IdAttach = reader.GetGuid(reader.GetOrdinal("IdAttach")),
                                Attach = GetAttach(reader.GetGuid(reader.GetOrdinal("IdAttach")))

                            };
                        }
                        return new Message
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("id")),
                            IdChat = reader.GetGuid(reader.GetOrdinal("IdChat")),
                            IdUser = reader.GetGuid(reader.GetOrdinal("IdUser")),
                            TimeCreate = reader.GetDateTime(reader.GetOrdinal("timeCreate")),
                            Text = reader.GetString(reader.GetOrdinal("text"))
                        };
                    }
                }
            }
        }

        public void SelfDestroy(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "delete from Message where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                    NLogger.Logger.Trace("База данных:удалено из таблицы:{0}:где MessageID:{1}", "[Message]", id);
                }
            }
        }

        public Message UpdateText(Guid id, string text)
        {
            if (text != null)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "update Message set Text = @Text where id = @id";

                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@Text", text);

                        command.ExecuteNonQuery();

                        NLogger.Logger.Trace("База данных:обновлено text:{0}:где MessageID:{1}", "[Message]", id);
                        return Get(id);
                    }
                }
            }
            return Get(id);
        }

    }
}
