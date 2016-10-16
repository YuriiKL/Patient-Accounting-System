using System;
using System.Collections.Generic;
using Patient_Accounting_System.Entities;

namespace Patient_Accounting_System.Repositories
{
    public interface ISqlAccountingProvidedServiceRepository
    {
        IEnumerable<AccountingProvidedService> GetDoctorAccountingInformation(DateTime fromDate, DateTime toDate);
        IEnumerable<AccountingProvidedService> GetPatientAccountingInformation(DateTime fromDate, DateTime toDate);
        IEnumerable<AccountingProvidedService> GetServiceAccountingInformation(DateTime fromDate, DateTime toDate);
    }
}