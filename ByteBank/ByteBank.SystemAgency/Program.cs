using ByteBank.Entities;
using ByteBank.SystemAgency.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ByteBank.SystemAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static void TestList()
        {
            #region LIST<STRING>
            var names = new List<string>()
            {
                "Teste A",
                "Teste X",
                "Teste R",
                "Teste B",
                "Teste F",
            };

            names.Sort();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region LIST<INT>
            var ages = new List<int>();

            ages.Add(1);
            ages.Add(12);
            ages.Add(23);
            ages.Add(36);
            ages.Add(41);

            ages.AddSeveral(34, 67, 23, 7);

            ages.Sort();

            for (int i = 0; i < ages.Count; i++)
            {
                int currentAge = ages[i];
                Console.WriteLine(currentAge);
            }

            #endregion

            #region LIST<CLASS> LINQ IENUMERABLE
            var accounts = new List<Account>()
            {
                new Account(8, 5),
                new Account(6, 2),
                null,
                new Account(9, 4),
                new Account(7, 3),
                null,
                new Account(10, 1)
            };

            var accountsOrder = accounts
                .Where(x => x != null)
                .OrderBy(conta => conta.Number);

            foreach (var account in accountsOrder)
            {
                if (account != null)
                {
                    Console.WriteLine($"Numero: {account.Number} - Agencia: {account.Agency}");
                }
            }

            #endregion

            Console.ReadLine();
        }

        static void TestListObject()
        {
            ListObject listAges = new ListObject();

            listAges.Add(10);
            listAges.Add(45);
            listAges.Add(23);
            listAges.AddSeveral(45, 43, 65, 87);

            for (int i = 0; i < listAges.Size; i++)
            {
                int age = (int)listAges[i];
                Console.WriteLine($"Idade no indice {i}: {age}");
            }
        }

        static void TestIndexadoresAndParams()
        {
            ListAccount list = new ListAccount();

            Account contaDoIrineu = new Account(891, 1234567);
            list.Add(contaDoIrineu);

            Account[] accounts = new Account[]
            {
                contaDoIrineu,
                new Account(231, 456879),
                new Account(678, 890567),
            };

            list.AddSeveral(accounts);

            for (int i = 0; i < list.Size; i++)
            {
                Account currentItem = list[i];

                Console.WriteLine($"Item na posição {i} conta {currentItem.Number}");
            }

            Console.ReadLine();
        }

        static void TestIndexOfAndSubstring()
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }

        static void TestIsNullOrEmpty()
        {
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();
        }

        static void TestManipulationString()
        {
            //Expressão regular, quantificadores
            string padrao = "[0-9]{4,5}-?{0,1}[0-9]{4}";

            string textoDeTeste = "Meu nome é Irineu, me ligue em 4578-2354";

            Console.WriteLine(Regex.Match(textoDeTeste, padrao));
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            string urlParams = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            URLArgumentValueExtractor extractor = new URLArgumentValueExtractor(urlParams);

            string valor = extractor.GetValue("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extractor.GetValue("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extractor.GetValue("VALOR"));
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";
            Console.WriteLine(mensagemOrigem.ToLower());

            //--------------------------------------------------------------------------------------------

            // Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------

            // Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();

        }

        static void TestObject()
        {
            Console.WriteLine("Irineuuuu");
            Console.WriteLine(345);
            Console.WriteLine(23.5);
            Console.WriteLine(true);

            object account = new Account(456, 678989);
            string accountToString = account.ToString();
            Console.WriteLine("Resultado: " + accountToString);

            Client clientA = new Client();
            clientA.Name = "Irineu";
            clientA.CPF = "345.567.123-00";
            clientA.Profession = "Desempregado";

            Client clientB = new Client();
            clientB.Name = "Irineu";
            clientB.CPF = "345.567.123-00";
            clientB.Profession = "Desempregado";

            object accountB = new Account(456, 678989);

            if (clientA.Equals(accountB))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.ReadLine();
        }

        static void TestArray()
        {
            #region Array Class

            Account[] accounts = new Account[]
            {
                new Account(123, 45601),
                new Account(789, 10102),
                new Account(112, 12103)
            };

            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"Indice: {i} Conta: {accounts[i].Number}");
            }

            Console.ReadLine();
            #endregion

            #region Array int

            int[] ages = new int[5];

            ages[0] = 1;
            ages[1] = 2;
            ages[2] = 3;
            ages[3] = 4;
            ages[4] = 5;

            int acumulator = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                int age = ages[i];

                Console.WriteLine($"Indice: {i} Idade: {age}");

                acumulator += age;
            }

            int media = acumulator / ages.Length;
            Console.WriteLine($"Média: {media}");
            Console.ReadLine();
            #endregion 
        }
    }
}
