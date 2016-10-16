using System;
namespace Patient_Accounting_System.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string PhoneNumber { get; set; }
    }
}
