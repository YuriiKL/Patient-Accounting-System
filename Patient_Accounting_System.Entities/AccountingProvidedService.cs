using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Accounting_System.Entities
{
    public class AccountingProvidedService:ProvidedService
    {
        public decimal TotalCost { get; set; }

        public int ServicesProvided { get; set; }

        public decimal AverageCostPerService { get; set; }
    }
}
