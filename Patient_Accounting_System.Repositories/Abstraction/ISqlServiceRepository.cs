using System.Collections.Generic;
using Patient_Accounting_System.Entities;

namespace Patient_Accounting_System.Repositories
{
    public interface ISqlServiceRepository
    {
        Service GetServiceById(int id);
        IEnumerable<Service> SearchServiceByName(string searchString);
    }
}