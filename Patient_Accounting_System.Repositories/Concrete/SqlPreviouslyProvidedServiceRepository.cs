using Patient_Accounting_System.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Accounting_System.Repositories
{
    public class SqlPreviouslyProvidedServiceRepository : SqlBaseRepository, ISqlPreviouslyProvidedServiceRepository
    {
        public SqlPreviouslyProvidedServiceRepository(string connection) : base(connection)
        {
        }

        public IEnumerable<ProvidedService> GetPreviuoslyProvidedServicesByDoctorId(int doctorId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetPreviouslyProvidedServices;
                    command.Parameters.AddWithValue("@PatientId", DBNull.Value);
                    command.Parameters.AddWithValue("@DoctorId", doctorId);
                    var providedServicesList = new List<ProvidedService>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            providedServicesList.Add(Parsers.ParseProvidedService(reader));
                        }

                        return providedServicesList;
                    }
                }
            }
        }

        public IEnumerable<ProvidedService> GetPreviuoslyProvidedServicesByPatientId(int patientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetPreviouslyProvidedServices;
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    command.Parameters.AddWithValue("@DoctorId", DBNull.Value);
                    var providedServicesList = new List<ProvidedService>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            providedServicesList.Add(Parsers.ParseProvidedService(reader));
                        }

                        return providedServicesList;
                    }
                }
            }
        }

        public IEnumerable<ProvidedService> GetPreviuoslyProvidedServices()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetPreviouslyProvidedServices;
                    command.Parameters.AddWithValue("@PatientId", DBNull.Value);
                    command.Parameters.AddWithValue("@DoctorId", DBNull.Value);
                    var providedServicesList = new List<ProvidedService>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            providedServicesList.Add(Parsers.ParseProvidedService(reader));
                        }

                        return providedServicesList;
                    }
                }
            }
        }

        public int AddNewProvidedService(ProvidedService providedService)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(StoredProcedureNames.spAddNewProvidedService, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ExecutionDateTime", SqlDbType.DateTime).Value = providedService.ExecutionDateTime;
                    if (String.IsNullOrWhiteSpace(providedService.Notes))
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = providedService.Notes;
                    }

                    command.Parameters.Add("@PatientId", SqlDbType.Int).Value = providedService.PatientId;
                    command.Parameters.Add("@DoctorId", SqlDbType.Int).Value = providedService.DoctorId;
                    command.Parameters.Add("@ServiceId", SqlDbType.Int).Value = providedService.ServiceId;
                    command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return providedService.ProvidedServiceId = (int)command.Parameters["@Id"].Value;
                }
            }
        }

        public int UpdateProvidedService(ProvidedService providedService)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(StoredProcedureNames.spUpdateProvidedService, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ProvidedServiceId", SqlDbType.Int).Value = providedService.ProvidedServiceId;

                    command.Parameters.Add("@ExecutionDateTime", SqlDbType.DateTime).Value = providedService.ExecutionDateTime;
                    if (String.IsNullOrWhiteSpace(providedService.Notes))
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = providedService.Notes;
                    }

                    command.Parameters.Add("@PatientId", SqlDbType.Int).Value = providedService.PatientId;
                    command.Parameters.Add("@DoctorId", SqlDbType.Int).Value = providedService.DoctorId;
                    command.Parameters.Add("@ServiceId", SqlDbType.Int).Value = providedService.ServiceId;
                    command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return providedService.ProvidedServiceId = (int)command.Parameters["@Id"].Value;
                }
            }
        }

        public int DeleteProvidedServiceByProvidedServiceId(int providedServiceId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(StoredProcedureNames.spDeleteProvidedService, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@ProvidedServiceId", SqlDbType.Int).Value = providedServiceId;

                    command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return (int)command.Parameters["@Id"].Value;
                }
            }

        }

    }
}
