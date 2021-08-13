using ByteBank.Entities;
using ByteBank.Exceptions;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetAccounts();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN.");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void GetAccounts()
        {
            using (ReadArchive read = new ReadArchive("Account.txt"))
            {
                read.ReadNextRow();
            }

            #region outra forma
            //ReadArchive readArchive = null;
            //try
            //{
            //    readArchive = new ReadArchive("account.txt");
            //    readArchive.ReadNextRow();
            //    readArchive.ReadNextRow();
            //    readArchive.ReadNextRow();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finaly...");
            //    if (readArchive != null)
            //    {
            //        readArchive.Dispose();
            //    }
            //}
            #endregion
        }

        private static void TestInnerException()
        {
            try
            {
                Account account = new Account(456, 456789);
                Account accountB = new Account(456, 456789);

                accountB.Transfer(1000, account);

                account.Deposit(100);
                Console.WriteLine($"Seu saldo é de R${account.Balance}");

                account.Sacar(-500);
            }
            catch (OperationFinanceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
        }

        #region Método divisão
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int value = 10;

            int resultado = Dividir(value, divisor);
            Console.WriteLine($"Resultado da divisão de {value} por { divisor}  é {resultado}");
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Exceção com numero = {numero} e divisor = {divisor}");
                throw;
                Console.WriteLine("Código depois do throw");
            }
        }
        #endregion
    }
}

