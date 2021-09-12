namespace ByteBank_SystemAgency.Models.Emploees
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(3000, cpf)
        {
        }

        public override void IncreaseSalary()
        {
            Salary *= 0.15;
        }

        internal protected override double GetBonus()
        {
            return Salary * 0.1;
        }
    }
}
