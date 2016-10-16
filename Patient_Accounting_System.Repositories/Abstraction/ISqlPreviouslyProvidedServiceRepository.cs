using System.Collections.Generic;
using Patient_Accounting_System.Entities;

namespace Patient_Accounting_System.Repositories
{
    public interface ISqlPreviouslyProvidedServiceRepository
    {
        int AddNewProvidedService(ProvidedService providedService);
        int DeleteProvidedServiceByProvidedServiceId(int providedServiceId);
        IEnumerable<ProvidedService> GetPreviuoslyProvidedServices();
        IEnumerable<ProvidedService> GetPreviuoslyProvidedServicesByDoctorId(int doctorId);
        IEnumerable<ProvidedService> GetPreviuoslyProvidedServicesByPatientId(int patientId);
        int UpdateProvidedService(ProvidedService providedService);
    }
}