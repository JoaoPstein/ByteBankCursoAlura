using ByteBank.Entities;
using ByteBank_SystemAgency.Models.Emploees;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SystemAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object

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
            #endregion

            #region Manipulação de string

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

            #endregion

            #region Testando IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();
            #endregion

            #region IndexOf e Substring
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();

            #endregion
        }
    }
}
