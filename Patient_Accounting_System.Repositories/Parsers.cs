using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_Accounting_System.Entities;
using System.Data.SqlClient;
using System.Globalization;

namespace Patient_Accounting_System.Repositories
{
    class Parsers
    {
        public static User ParseUser(SqlDataReader reader)
        {
            User user = new User();
            if (reader.ColumnExists("Id"))
            {
                user.Id = reader["Id"] is DBNull
                ? 0
                : Convert.ToInt32(reader["Id"], CultureInfo.CurrentCulture);
            }
            if (reader.ColumnExists("FirstName"))
            {
                user.FirstName = reader["FirstName"] is DBNull
                ? String.Empty
                : reader["FirstName"].ToString();
            }
            if (reader.ColumnExists("LastName"))
            {
                user.LastName = reader["LastName"] is DBNull
                ? String.Empty
                : reader["LastName"].ToString();
            }
            if (reader.ColumnExists("Login"))
            {
                user.Login = reader["Login"] is DBNull
                ? String.Empty
                : reader["Login"].ToString();
            }
            if (reader.ColumnExists("Password"))
            {
                user.Password = reader["Password"] is DBNull
                ? String.Empty
                : reader["Password"].ToString();
            }

            return user;
        }

        public static Patient ParsePatient(SqlDataReader reader)
        {
            Patient patient = new Patient();
            if (reader.ColumnExists("PatientId"))
            {
                patient.PatientId = reader["PatientId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["PatientId"], CultureInfo.CurrentCulture);
            }
            if (reader.ColumnExists("FirstName"))
            {
                patient.FirstName = reader["FirstName"] is DBNull
                ? String.Empty
                : reader["FirstName"].ToString();
            }
            if (reader.ColumnExists("LastName"))
            {
                patient.LastName = reader["LastName"] is DBNull
                ? String.Empty
                : reader["LastName"].ToString();
            }
            if (reader.ColumnExists("Email"))
            {
                patient.Email = reader["Email"] is DBNull
                ? String.Empty
                : reader["Email"].ToString();
            }
            if (reader.ColumnExists("PhoneNumber"))
            {
                patient.PhoneNumber = reader["PhoneNumber"] is DBNull
                ? String.Empty
                : reader["PhoneNumber"].ToString();
            }

            if (reader.ColumnExists("BirthDate"))
            {
                patient.BirthDate = reader["BirthDate"] is DBNull
                ? DateTime.MinValue
                : reader.GetDateTime(reader.GetOrdinal("BirthDate"));
            }
            if (reader.ColumnExists("PatientId"))
            {
                patient.Sex = reader["Sex"] is DBNull
                ? (short)0
                : Convert.ToInt16(reader["Sex"], CultureInfo.CurrentCulture);
            }
            if (reader.ColumnExists("Notes"))
            {
                patient.Notes = reader["Notes"] is DBNull
                ? String.Empty
                : reader["Notes"].ToString();
            }
            return patient;
        }

        public static Doctor ParseDoctor(SqlDataReader reader)
        {
            Doctor doctor = new Doctor();
            if (reader.ColumnExists("DoctorId"))
            {
                doctor.DoctorId = reader["DoctorId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["DoctorId"], CultureInfo.CurrentCulture);
            }
            if (reader.ColumnExists("FirstName"))
            {
                doctor.FirstName = reader["FirstName"] is DBNull
                ? String.Empty
                : reader["FirstName"].ToString();
            }
            if (reader.ColumnExists("LastName"))
            {
                doctor.LastName = reader["LastName"] is DBNull
                ? String.Empty
                : reader["LastName"].ToString();
            }
            if (reader.ColumnExists("Title"))
            {
                doctor.Title = reader["Title"] is DBNull
                ? String.Empty
                : reader["Title"].ToString();
            }
            if (reader.ColumnExists("PhoneNumber"))
            {
                doctor.PhoneNumber = reader["PhoneNumber"] is DBNull
                ? String.Empty
                : reader["PhoneNumber"].ToString();
            }

            return doctor;
        }

        public static ProvidedService ParseProvidedService(SqlDataReader reader)
        {
            ProvidedService providedService = new ProvidedService();

            if (reader.ColumnExists("ProvidedServiceId"))
            {
                providedService.ProvidedServiceId = reader["ProvidedServiceId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["ProvidedServiceId"], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists("ExecutionDateTime"))
            {
                providedService.ExecutionDateTime = reader["ExecutionDateTime"] is DBNull
                ? DateTime.MinValue
                : reader.GetDateTime(reader.GetOrdinal("ExecutionDateTime"));
            }

            if (reader.ColumnExists("Notes"))
            {
                providedService.Notes = reader["Notes"] is DBNull
                ? String.Empty
                : reader["Notes"].ToString();
            }

            if (reader.ColumnExists("PatientId"))
            {
                providedService.PatientId = reader["PatientId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["PatientId"], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists("DoctorId"))
            {
                providedService.DoctorId = reader["DoctorId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["DoctorId"], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists("ServiceId"))
            {
                providedService.ServiceId = reader["ServiceId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["ServiceId"], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists("ServiceName"))
            {
                providedService.ServiceName = reader["ServiceName"] is DBNull
                ? String.Empty
                : reader["ServiceName"].ToString();
            }

            if (reader.ColumnExists("ServicePrice"))
            {
                providedService.ServicePrice = reader["ServicePrice"] is DBNull
                ? 0
                : Convert.ToDecimal(reader["ServicePrice"], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists("PatientFirstName"))
            {
                providedService.PatientFirstName = reader["PatientFirstName"] is DBNull
                ? String.Empty
                : reader["PatientFirstName"].ToString();
            }

            if (reader.ColumnExists("PatientLastName"))
            {
                providedService.PatientLastName = reader["PatientLastName"] is DBNull
                ? String.Empty
                : reader["PatientLastName"].ToString();
            }

            if (reader.ColumnExists("DoctorFirstName"))
            {
                providedService.DoctorFirstName = reader["DoctorFirstName"] is DBNull
                ? String.Empty
                : reader["DoctorFirstName"].ToString();
            }

            if (reader.ColumnExists("DoctorLastName"))
            {
                providedService.DoctorLastName = reader["DoctorLastName"] is DBNull
                ? String.Empty
                : reader["DoctorLastName"].ToString();
            }

            if (reader.ColumnExists("DoctorTitle"))
            {
                providedService.DoctorTitle = reader["DoctorTitle"] is DBNull
                ? String.Empty
                : reader["DoctorTitle"].ToString();
            }

            return providedService;
        }

        public static AccountingProvidedService ParseAccountingProvidedService(SqlDataReader reader)
        {
            ProvidedService providedService = ParseProvidedService(reader);

            AccountingProvidedService accountingProvidedService = new AccountingProvidedService()
            {
                PatientId = providedService.PatientId,
                DoctorId = providedService.DoctorId,
                ServiceId = providedService.ServiceId,
                ServiceName = providedService.ServiceName,
                ServicePrice = providedService.ServicePrice,
                PatientFirstName = providedService.PatientFirstName,
                PatientLastName = providedService.PatientLastName,
                DoctorFirstName = providedService.DoctorFirstName,
                DoctorLastName = providedService.DoctorLastName,
                DoctorTitle = providedService.DoctorTitle
            };

            if (reader.ColumnExists("TotalCost"))
            {
                accountingProvidedService.TotalCost = reader["TotalCost"] is DBNull
                ? 0
                : Convert.ToDecimal(reader["TotalCost"], CultureInfo.CurrentCulture);
            }

            if (reader.ColumnExists("AverageCostPerService"))
            {
                accountingProvidedService.AverageCostPerService = reader["AverageCostPerService"] is DBNull
                ? 0
                : Convert.ToDecimal(reader["AverageCostPerService"], CultureInfo.CurrentCulture);
            }
            if (reader.ColumnExists("ServicesProvided"))
            {
                accountingProvidedService.ServicesProvided = reader["ServicesProvided"] is DBNull
                ? 0
                : Convert.ToInt32(reader["ServicesProvided"], CultureInfo.CurrentCulture);
            }

            return accountingProvidedService;
        }
        public static Service ParseService(SqlDataReader reader)
        {
            Service service = new Service();
            if (reader.ColumnExists("ServiceId"))
            {
                service.ServiceId = reader["ServiceId"] is DBNull
                ? 0
                : Convert.ToInt32(reader["ServiceId"], CultureInfo.CurrentCulture);
            }
            if (reader.ColumnExists("Name"))
            {
                service.Name = reader["Name"] is DBNull
                ? String.Empty
                : reader["Name"].ToString();
            }
            if (reader.ColumnExists("Price"))
            {
                service.Price = reader["Price"] is DBNull
                ? 0
                : Convert.ToDecimal(reader["Price"], CultureInfo.CurrentCulture);
            }

            return service;
        }
    }
}
