using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Accounting_System.Repositories
{
    public static class ExtentionMethods
    {
        public static bool ColumnExists(this IDataRecord reader, string columnName)
        {
            for (var i = 0; i < reader.FieldCount; i++)
            {
                if (string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
