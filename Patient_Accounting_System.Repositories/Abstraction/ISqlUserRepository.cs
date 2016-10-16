using Patient_Accounting_System.Entities;

namespace Patient_Accounting_System.Repositories
{
    public interface ISqlUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}