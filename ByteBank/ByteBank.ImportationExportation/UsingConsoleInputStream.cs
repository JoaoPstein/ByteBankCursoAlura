using System;
using System.IO;

namespace ByteBank.ImportationExportation
{
    partial class Program
    {
        static void UsingStreamInput()
        {
            using (var inFlow = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesRead = inFlow.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesRead);

                    fs.Flush();

                    Console.WriteLine($"Bytes lidos da console: {bytesRead}");
                }
            }
        }
    }
}
