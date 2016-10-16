using System.Collections.Generic;
using Patient_Accounting_System.Entities;

namespace Patient_Accounting_System.Repositories
{
    public interface ISqlPatientRepository
    {
        int AddNewPatient(Patient patient);
        Patient GetPatientById(int id);
        IEnumerable<Patient> SearchPatientsByName(string searchString);
        int UpdatePatient(Patient patient);
    }
}