using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Accounting_System.DesktopUI.Code
{
    // Review TK: It is a good practice to set access modifier before class
    // I would prefer to use hashing as service but not static method
    // For example, you could create interface IHashService and implementation MD5HashService
    class Hashes
    {
        public static string GetMD5Hash(string text)
        {
            using (MD5 cryptoProvider = new MD5CryptoServiceProvider())
            {
                byte[] result = cryptoProvider.ComputeHash(Encoding.Default.GetBytes(text));
                StringBuilder stringHash = new StringBuilder();

                for (int i = 0; i < result.Length; i++)
                {
                    stringHash.Append(result[i].ToString("x2"));
                }

                return stringHash.ToString();
            }
        }
    }
}
