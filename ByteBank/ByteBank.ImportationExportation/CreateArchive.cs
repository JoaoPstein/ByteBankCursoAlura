using System;
using System.IO;
using System.Text;

namespace ByteBank.ImportationExportation
{
    partial class Program
    {
        static void CreateArchive()
        {
            var pathNewArchive = "contasExportadas.csv";

            using (var flowFile = new FileStream(pathNewArchive, FileMode.CreateNew))
            {
                var accountWithString = "456, 12345, 567.76, Gustavo Santos";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(accountWithString);

                flowFile.Write(bytes, 0, bytes.Length);
            }
        }

        static void CreateArchiveWithWriter()
        {
            var pathArchive = "contasExportadas.csv";

            using (var flowArchive = new FileStream(pathArchive, FileMode.CreateNew))
            using (var writer = new StreamWriter(flowArchive))
            {
                writer.Write("123, 789543, 897.76, Jacaré Paguá");
            }
        }

        static void CopyArchive()
        {
            var archiveOrigin = new FileStream("C:/Users/joao.campos/source/repos/ByteBankCursoAlura/" +
                "ByteBank/ByteBank.ImportationExportation/bin/Debug/netcoreapp3.1/contasExportadas.csv", FileMode.Open);
            var newArchive = new FileStream("C:/Users/joao.campos/source/repos/ByteBankCursoAlura/" +
                "ByteBank/ByteBank.ImportationExportation/bin/Debug/netcoreapp3.1/contasExportadas_copia.csv", FileMode.Create);
            var buffer = new byte[1024];

            using (archiveOrigin)
            using (newArchive)
            {
                var bytesLidos = -1;
                while (bytesLidos != 0)
                {
                    bytesLidos = archiveOrigin.Read(buffer, 0, 1024);
                    newArchive.Write(buffer, 0, bytesLidos);
                }
            }

            var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original!");
            newArchive.Write(rodape, 0, rodape.Length);
        }

        static void TestWriter()
        {
            var pathArchive = "teste.txt";

            using (var flowFile = new FileStream(pathArchive, FileMode.Create))
            using (var writer = new StreamWriter(flowFile))
            {
                for (int i = 0; i < 100; i++)
                {
                    writer.WriteLine($"Linha {i}");

                    writer.Flush(); // Ele despeja o buffer pro stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo");
                    Console.ReadLine();
                }
            }
        }
    }
}
