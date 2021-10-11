using ByteBank.Entities;
using System;
using System.IO;

namespace ByteBank.ImportationExportation
{
    partial class Program
    {
        static void UsingStreamReader()
        {
            var addressFile = "contas.txt";

            using (var fileStream = new FileStream(addressFile, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var account = ConvertStringToAccount(line);

                    Console.WriteLine($"{account.Holder.Name}: {account}");
                }
            }
            Console.ReadLine();
        }

        static Account ConvertStringToAccount(string line)
        {
            string[] fields = line.Split(',');

            var agency = fields[0];
            var number = fields[1];
            var balance = fields[2].Replace(".", ",");
            var name = fields[3];

            var convertAgency = int.Parse(agency);
            var convertNumber = int.Parse(number);
            var convertBalance = double.Parse(balance);

            var holder = new Client();
            holder.Name = name;

            var result = new Account(convertAgency, convertNumber);
            result.Deposit(convertBalance);
            result.Holder = holder;

            return result;
        }
    }
}
