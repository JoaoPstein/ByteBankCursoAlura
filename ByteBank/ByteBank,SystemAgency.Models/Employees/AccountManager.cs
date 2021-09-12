namespace ByteBank_SystemAgency.Models.Emploees
{
    public class AccountManager : EmployeeAutentication
    {
        public AccountManager(string cpf) : base(4000, cpf)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }

        protected internal override double GetBonus()
        {
            return Salary * 0.25;
        }
    }
}
