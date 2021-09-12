using ByteBank_SystemAgency.Models.Emploees;

namespace ByteBank.SystemAgency
{
    public class Trainee : Employee
    {
        public Trainee(double salario, string cpf)
           : base(salario, cpf)
        {

        }

        public override void IncreaseSalary()
        {
            // Qualquer código
        }

        protected override double GetBonus()
        {
            throw new System.NotImplementedException();
        }
    }
}
