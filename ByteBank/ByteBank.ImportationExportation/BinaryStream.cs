using System;
using System.IO;

namespace ByteBank.ImportationExportation
{
    partial class Program
    {
        static void WriterBinary()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(123);
                writer.Write(456789);
                writer.Write(786.89);
                writer.Write("Teste da Silva");
            }
        }

        static void ReadBinary()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var reader = new BinaryReader(fs))
            {
                var agency = reader.ReadInt32();
                var numberAccount = reader.ReadInt32();
                var balance = reader.ReadDouble();
                var name = reader.ReadString();

                Console.WriteLine($"Agencia: {agency}, Numero da conta: {numberAccount}, " +
                    $"Saldo: {balance}, Nome: {name}");
            }
        }

        static void TesteBinaryAndStream()
        {
            var number = 691693903;

            using (var fs = new FileStream("C:/Users/joao.campos/source/repos/ByteBankCursoAlura/" +
                "ByteBank/ByteBank.ImportationExportation/bin/Debug/netcoreapp3.1/binaryWriter.csv", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(number);
            }

            using (var fs = new FileStream("C:/Users/joao.campos/source/repos/ByteBankCursoAlura/" +
                "ByteBank/ByteBank.ImportationExportation/bin/Debug/netcoreapp3.1/streamWriter.csv", FileMode.Create))
            using (var writer = new StreamWriter(fs))
            {
                writer.Write(number);
            }
        }
    }
}
