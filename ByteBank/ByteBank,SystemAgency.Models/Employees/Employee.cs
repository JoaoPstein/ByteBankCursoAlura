using System;

namespace ByteBank_SystemAgency.Models.Emploees
{
    public abstract class Employee
    {
         public static int TotalEmployees { get; private set; }

        public string name { get; set; }

        public string CPF { get; private set; }
        
        public double Salary { get; protected set; }

        public Employee(double wage, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salary = wage;

            TotalEmployees++;
        }

        public abstract void IncreaseSalary();

        internal protected abstract double GetBonus();
    }
}
