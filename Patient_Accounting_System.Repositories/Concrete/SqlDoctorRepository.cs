using System;
using Patient_Accounting_System.Entities;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Patient_Accounting_System.Repositories
{
    public class SqlDoctorRepository : SqlBaseRepository, ISqlDoctorRepository
    {
        public SqlDoctorRepository(string connection) : base(connection)
        {
        }

        public Doctor GetDoctorById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetDoctor;
                    command.Parameters.AddWithValue("@DoctorId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Doctor doctor = null;

                        if (reader.Read())
                        {
                            doctor = Parsers.ParseDoctor(reader);
                        }

                        return doctor;
                    }
                }
            }
        }

        public IEnumerable<Doctor> SearchDoctorsByName(string searchString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spSearchDoctors;
                    command.Parameters.AddWithValue("@SearchString", searchString);

                    var doctors = new List<Doctor>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(Parsers.ParseDoctor(reader));
                        }

                        return doctors;
                    }
                }
            }
        }
    }
}
