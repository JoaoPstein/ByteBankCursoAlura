namespace ByteBank_SystemAgency.Models.Emploees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }

        protected internal override double GetBonus()
        {
            return Salary * 0.17;
        }
    }
}
