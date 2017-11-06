using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.DataLayer;
using Messenger.Model;
using System.Data.SqlClient;
using Messenger.Logger;


namespace Messenger.DataLayer.Sql
{
    public class UserLayer : IUserLayer
    {
        private readonly string _connectionString;

        public UserLayer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User Create(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into ListOfUsers (id, password, photo, firstName, secondName, timeOfDelMes) 
                                                        values (@id, @password, @photo, @firstName, @secondName, @timeOfDelMes)";
                    user.Id = Guid.NewGuid();
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@photo", user.Photo);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@secondName", user.SecondName);
                    command.Parameters.AddWithValue("@timeOfDelMes", user.TimeOfDelMes);

                    command.ExecuteNonQuery();

                    NLogger.Logger.Trace("База данных:Добавлено в таблицу:{0}:значения (IdUser: {1}, FirstName:{2}, SecondName:{3}, Password:{4})", "[ListOfUsers]", user.Id, user.SecondName, user.FirstName, user.Password);
                    return user;
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
                    command.CommandText = "delete from ListOfUsers where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    NLogger.Logger.Trace("База данных:удалено из таблицы:{0}:где UserID:{1}", "[ListOfUsers]", id);
                }
            }
        }


        public User Get(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select top(1) id, password, photo, firstName, secondName, timeOfDelMes 
                                                                                    from ListOfUsers where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Пользователя с таким id {id} нет!");
                        }

                        return new User
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

        private void Update<T>(Guid id, T value, string columnName)
        {
            if (value != null) { 
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "update ListOfUsers set " + columnName + " = " + "@" + columnName + " where id = @id";

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@" + columnName, value);

                    command.ExecuteNonQuery();

                    
                    }
            }
            }
        }

        public User UpdateFirstName(Guid id, string firstName)
        {
            Update(id, firstName, "firstName");
            NLogger.Logger.Trace("База данных:обновлено FirstName:{0}:где UserID:{1}", "[ListOfUsers]", id);
            return Get(id);
        }

        public User UpdateSecondName(Guid id, string secondName)
        {
            Update(id, secondName, "secondName");
            NLogger.Logger.Trace("База данных:обновлено SecondName:{0}:где UserID:{1}", "[ListOfUsers]", id);
            return Get(id);
        }

        public User UpdatePassword(Guid id, string password)
        {
            Update(id, password, "password");
            NLogger.Logger.Trace("База данных:обновлено Password:{0}:где UserID:{1}", "[ListOfUsers]", id);
            return Get(id);
        }

        public User UpdatePhoto(Guid id, byte[] photo)
        {
            Update(id, photo, "photo");
            NLogger.Logger.Trace("База данных:обновлено Photo:{0}:где UserID:{1}", "[ListOfUsers]", id);
            return Get(id);
        }

        public User UpdateTimeDelMes(Guid id, DateTime time)
        {
            Update(id, time, "timeOfDelMes");
            NLogger.Logger.Trace("База данных:обновлено TimeDelMes:{0}:где UserID:{1}", "[ListOfUsers]", id);
            return Get(id);
        }
    }
}