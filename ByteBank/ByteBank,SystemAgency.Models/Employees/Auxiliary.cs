namespace ByteBank_SystemAgency.Models.Emploees
{
    public class Auxiliary : Employee
    {
        public Auxiliary(string cpf) : base(2000, cpf)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        protected internal override double GetBonus()
        {
            return Salary * 0.2;
        }
    }
}
