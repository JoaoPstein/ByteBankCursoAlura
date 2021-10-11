using System;
using System.IO;
using System.Text;

namespace ByteBank.ImportationExportation
{
    partial class Program
    {
        static void HandlingFileStream()
        {
            var addressFile = "contas.txt";

            using (var fileStream = new FileStream(addressFile, FileMode.Open))
            {
                var buffer = new byte[1024]; //1kb

                var numberOfBytesRead = -1;

                while (numberOfBytesRead != 0)
                {
                    numberOfBytesRead = fileStream.Read(buffer, 0, 1024);
                    WriteBuffer(buffer, numberOfBytesRead);
                }
            }
        }

        static void WriteBuffer(byte[] buffer, int bytesRead)
        {
            var utf = Encoding.Default;

            var text = utf.GetString(buffer, 0, bytesRead);

            Console.Write(text);

            //foreach (var item in buffer)
            //{
            //    Console.Write(item);
            //    Console.Write(" ");
            //}
        }
    }
}
