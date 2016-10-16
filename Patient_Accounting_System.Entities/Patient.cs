using System;

namespace Patient_Accounting_System.Entities
{
    public class Patient
    { 
        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public short Sex { get; set; }

        public string SexString
        {
            get
            {
                switch (Sex)
                {
                    case 0: return "Not Known"; 
                    case 1: return "Male";
                    case 2: return "Female";
                    case 9: return "Not Specified";
                    default: return String.Empty;
                }      
            }
        }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Notes { get; set; }
    }
}
