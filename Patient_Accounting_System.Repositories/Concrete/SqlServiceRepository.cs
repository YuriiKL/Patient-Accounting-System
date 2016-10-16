using Patient_Accounting_System.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Accounting_System.Repositories
{
    public class SqlServiceRepository : SqlBaseRepository, ISqlServiceRepository
    {
        public SqlServiceRepository(string connection) : base(connection)
        {
        }

        public Service GetServiceById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetService;
                    command.Parameters.AddWithValue("@ServiceId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Service service = new Service();

                        if (reader.Read())
                        {
                            service = Parsers.ParseService(reader);
                        }

                        return service;
                    }
                }
            }
        }

        public IEnumerable<Service> SearchServiceByName(string searchString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spSearchServices;
                    command.Parameters.AddWithValue("@SearchString", searchString);

                    var services = new List<Service>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            services.Add(Parsers.ParseService(reader));
                        }

                        return services;
                    }
                }
            }
        }
    }
}
