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
    public class SqlPatientRepository : SqlBaseRepository, ISqlPatientRepository
    {
        public SqlPatientRepository(string connection) : base(connection)
        {
        }

        public Patient GetPatientById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetPatient;
                    command.Parameters.AddWithValue("@PatientId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Patient patient = new Patient();

                        if (reader.Read())
                        {
                            patient = Parsers.ParsePatient(reader);
                        }

                        return patient;
                    }
                }
            }
        }

        public int AddNewPatient(Patient patient)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(StoredProcedureNames.spAddNewPatient, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = patient.BirthDate;
                    if (String.IsNullOrWhiteSpace(patient.Notes))
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = patient.Notes;
                    }
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patient.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patient.LastName;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = patient.PhoneNumber;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = patient.Email;
                    command.Parameters.Add("@Sex", SqlDbType.SmallInt).Value = patient.Sex;

                    command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return patient.PatientId = (int)command.Parameters["@Id"].Value;
                }
            }
        }

        public int UpdatePatient(Patient patient)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(StoredProcedureNames.spUpdatePatient, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@PatientId", SqlDbType.Int).Value = patient.PatientId;
                    command.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = patient.BirthDate;

                    if (String.IsNullOrWhiteSpace(patient.Notes))
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = patient.Notes;
                    }
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = patient.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = patient.LastName;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = patient.PhoneNumber;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = patient.Email;
                    command.Parameters.Add("@Sex", SqlDbType.SmallInt).Value = patient.Sex;

                    command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    return patient.PatientId = (int)command.Parameters["@Id"].Value;
                }
            }
        }

        public IEnumerable<Patient> SearchPatientsByName(string searchString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spSearchPatients;
                    command.Parameters.AddWithValue("@SearchString", searchString);

                    var patients = new List<Patient>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(Parsers.ParsePatient(reader));
                        }

                        return patients;
                    }
                }
            }
        }
    }
}
