namespace Patient_Accounting_System.Entities
{
    public partial class User
    {
        // Review TK: As I noted you usded different convention for naming of If fields.
        // It would be great to have a similar approach for naming such fields. 
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}