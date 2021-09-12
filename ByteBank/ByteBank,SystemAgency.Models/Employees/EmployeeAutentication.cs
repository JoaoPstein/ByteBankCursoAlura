using ByteBank_SystemAgency.Models.Autentication;

namespace ByteBank_SystemAgency.Models.Emploees
{
    public abstract class EmployeeAutentication : Employee, IAutentication
    {
        private AutenticationHelper _autenticationHelper = new AutenticationHelper();
        public string Password { get; set; }

        protected EmployeeAutentication(double wage, string cpf) : base(wage, cpf)
        {
        }

        public bool Autentication(string password)
        {
            return _autenticationHelper.ComparePassword(Password, password);
        }
    }
}
