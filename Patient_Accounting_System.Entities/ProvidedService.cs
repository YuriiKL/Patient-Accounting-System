using System;

namespace Patient_Accounting_System.Entities
{
    public class ProvidedService
    {
        public int ProvidedServiceId { get; set; }

        public DateTime ExecutionDateTime { get; set; }

        public string Notes { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public int ServiceId { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientLastName { get; set; }

        public string DoctorFirstName { get; set; }

        public string DoctorLastName { get; set; }

        public string DoctorTitle { get; set; }

        public string ServiceName { get; set; }

        public decimal ServicePrice { get; set; }
    }
}