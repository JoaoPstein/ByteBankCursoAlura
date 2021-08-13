using System;
using System.IO;

namespace ByteBank
{
    public class ReadArchive : IDisposable
    {
        public string Archive { get; }

        public ReadArchive(string arquivo)
        {
            Archive = arquivo;

            throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string ReadNextRow()
        {
            Console.WriteLine("Lendo linha. . .");

            throw new IOException();
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
