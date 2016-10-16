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
    public class SqlAccountingProvidedServiceRepository : SqlBaseRepository, ISqlAccountingProvidedServiceRepository
    {
        private enum AccountingInformationType
        {
            ByDoctor,
            ByPatient,
            ByService
        }

        public SqlAccountingProvidedServiceRepository(string connection) : base(connection)
        {
        }

        public IEnumerable<AccountingProvidedService> GetServiceAccountingInformation(DateTime fromDate, DateTime toDate)
        {
            return GetAccountingInformation(fromDate, toDate, AccountingInformationType.ByService);
        }

        public IEnumerable<AccountingProvidedService> GetPatientAccountingInformation(DateTime fromDate, DateTime toDate)
        {
            return GetAccountingInformation(fromDate, toDate, AccountingInformationType.ByPatient);
        }

        public IEnumerable<AccountingProvidedService> GetDoctorAccountingInformation(DateTime fromDate, DateTime toDate)
        {
            return GetAccountingInformation(fromDate, toDate, AccountingInformationType.ByDoctor);
        }

        private IEnumerable<AccountingProvidedService> GetAccountingInformation(DateTime fromDate, DateTime toDate,AccountingInformationType accountingInformationType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureNames.spGetCost;

                    command.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = fromDate;
                    command.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = toDate;
                    if (accountingInformationType == AccountingInformationType.ByDoctor)
                    {
                        command.Parameters.AddWithValue("@ByDoctors", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ByDoctors", 0);
                    }

                    if (accountingInformationType == AccountingInformationType.ByPatient)
                    {
                        command.Parameters.AddWithValue("@ByPatients", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ByPatients", 0);
                    }

                    if (accountingInformationType == AccountingInformationType.ByService)
                    {
                        command.Parameters.AddWithValue("@ByServices", 1);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ByServices", 0);
                    }

                    var AccountingProvidedServicesList = new List<AccountingProvidedService>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AccountingProvidedServicesList.Add(Parsers.ParseAccountingProvidedService(reader));
                        }

                        return AccountingProvidedServicesList;
                    }
                }
            }
        }
    }
}
