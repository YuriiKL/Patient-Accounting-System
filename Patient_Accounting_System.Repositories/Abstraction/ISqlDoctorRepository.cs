using System.Collections.Generic;
using Patient_Accounting_System.Entities;

namespace Patient_Accounting_System.Repositories
{
    public interface ISqlDoctorRepository
    {
        Doctor GetDoctorById(int id);
        IEnumerable<Doctor> SearchDoctorsByName(string searchString);
    }
}