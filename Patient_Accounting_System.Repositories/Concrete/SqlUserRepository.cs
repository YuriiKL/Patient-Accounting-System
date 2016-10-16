using System;
using Patient_Accounting_System.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Patient_Accounting_System.Repositories
{
    public class SqlUserRepository : SqlBaseRepository, ISqlUserRepository
    {
        public SqlUserRepository(string connection) : base(connection)
        {
        }

        public User GetUserByLogin(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetUserByLogin;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;

                        if (reader.Read())
                        {
                            user = Parsers.ParseUser(reader);
                        }

                        return user;
                    }
                }
            }
        }
    }
}
