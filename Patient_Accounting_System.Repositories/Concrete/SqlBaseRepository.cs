using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Patient_Accounting_System.Repositories
{
    public abstract class SqlBaseRepository
    {
        protected string connectionString { get; }

        protected SqlBaseRepository(string connection)
        {
            connectionString = connection;
        }
    }
}
