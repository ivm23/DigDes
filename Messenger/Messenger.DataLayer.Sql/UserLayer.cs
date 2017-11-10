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


            if (!existLogin(user.Login))
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

                        command.CommandText = @"insert into UsersLogin (id, login) values (@id1, @login)";
                        command.Parameters.AddWithValue("@id1", user.Id);
                        command.Parameters.AddWithValue("@login", user.Login);
                        command.ExecuteNonQuery();

                        NLogger.Logger.Trace("База данных:Добавлено в таблицу:{0}:значения (IdUser: {1}, Login:{2})", "[ListOfUsers]", user.Id, user.Login);
                        return user;
                    }
                }
            }
            else
                throw new ArgumentException($"Пользователь с login: {user.Login} уже существует");
        }


        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = "delete from UsersLogin where id = @id1";

                    command.Parameters.AddWithValue("@id1", id);

                    command.ExecuteNonQuery();

                    command.CommandText = "delete from ListOfUsers where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();


                    NLogger.Logger.Trace("База данных:удалено из таблицы:{0}:где UserID:{1}", "[ListOfUsers]", id);
                }
            }
        }

        string GetLogin(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select login from UsersLogin where id = @id";

                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Пользователя с таким id {id} нет!");
                        }
                        return reader.GetString(reader.GetOrdinal("login"));
                    }
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
                    //command.CommandText = @"select top(1) login, id, password, photo, firstName, secondName, timeOfDelMes from UsersLogin FULL JOIN ListOfUsers on UsersLogin.id = ListOfUsers.id where id = @id";
                    command.CommandText = @"select top(1) id, password, photo, firstName, secondName, timeOfDelMes from ListOfUsers where id = @id";

                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Пользователя с таким id {id} нет!");
                        }

                        var user = new User
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("id")),
                            Login = GetLogin(id),
                            Password = reader.GetString(reader.GetOrdinal("password")),
                            Photo = reader.GetSqlBinary(reader.GetOrdinal("photo")).Value,
                            FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                            SecondName = reader.GetString(reader.GetOrdinal("secondName")),
                            TimeOfDelMes = reader.GetDateTime(reader.GetOrdinal("timeOfDelMes"))
                        };
                        return user;

                    }
                }
            }
        }


        bool existLogin(string login)
        {
            try
            {
                GetId(login);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Guid GetId(string login)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select id from UsersLogin where login = @login";

                    command.Parameters.AddWithValue("@login", login);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            throw new ArgumentException($"Пользователя с таким login {login} нет!");
                        }
                        return reader.GetGuid(reader.GetOrdinal("id"));
                    }
                }
            }
        }

        private void Update<T>(Guid id, T value, string columnName)
        {
            if (value != null)
            {
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

        public User UpdateLogin(Guid id, string login)
        {
            if (!existLogin(login))
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "update UsersLogin set login = @login where id = @id";

                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@login", login);

                        command.ExecuteNonQuery();
                    }
                }
                NLogger.Logger.Trace("База данных:обновлено Login:{0}:где UserID:{1}", "[ListOfUsers]", id);
                return Get(id);
            }
            else throw new ArgumentException($"Пользователь с login: {login} уже существует");
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

        public List<User> AllUsers(Guid id)
        {
            List<User> users = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"select id, password, photo, firstName, secondName, timeOfDelMes from ListOfUsers where not(id = @id)";

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var user = new User
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                Photo = new byte[] { 1, 2, 3 },
                                FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                                SecondName = reader.GetString(reader.GetOrdinal("secondName")),
                                TimeOfDelMes = reader.GetDateTime(reader.GetOrdinal("timeOfDelMes"))
                            };
                            user.Login = GetLogin(user.Id);
                            users.Add(user);
                        }

                        return users;
                    }
                }
            }
        }
    }
}