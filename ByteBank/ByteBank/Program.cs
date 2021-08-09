using ByteBank.Entities;
using ByteBank.Validations;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account(456, 456789);

                account.Deposit(100);
                Console.WriteLine($"Seu saldo é de R${account.Balance}");

                account.Sacar(-500);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {
                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo saldo insuficiente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Metodo();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
                Console.WriteLine("Código depois do throw");
            }
        }

    }
}

