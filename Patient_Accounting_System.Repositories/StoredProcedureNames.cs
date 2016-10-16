using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Accounting_System.Repositories
{
    public static class StoredProcedureNames
    {
        public const string spGetUserByLogin = "spGetUser";
        public const string spAddNewPatient = "spAddNewPatient";
        public const string spAddNewProvidedService = "spAddNewProvidedService";
        public const string spUpdatePatient = "spUpdatePatient";
        public const string spUpdateProvidedService = "spUpdateProvidedService";
        public const string spGetPreviouslyProvidedServices = "spGetPreviouslyProvidedServices";
        public const string spGetTotalCost = "spGetTotalCost";
        public const string spGetCost = "spGetCost";
        public const string spGetUser = "spGetUser";
        public const string spGetPatient = "spGetPatient";
        public const string spGetDoctor = "spGetDoctor";
        public const string spGetService = "spGetService";
        public const string spSearchPatients = "spSearchPatients";
        public const string spSearchDoctors = "spSearchDoctors";
        public const string spSearchServices = "spSearchServices";
        public const string spDeleteProvidedService = "spDeleteProvidedService";
    }
}
