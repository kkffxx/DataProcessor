using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parsing command line options");

            var address = Console.ReadLine();

            if (address.Contains("file"))
            {
                Console.WriteLine($"Single file {address} selected");
                ProcessSingleFile(address);
            }
            else if (address == "--dir")
            {
                var directoryPath = Path.GetDirectoryName(address);
                Console.WriteLine($"Directory {directoryPath} selected for {address} files");
                ProcessDircetory(directoryPath, address);
            }
            else
            {
                Console.WriteLine("Inavlid option");
            }

            Console.WriteLine("Press Enter to quit.");
            Console.ReadLine();
        }

        private static void ProcessDircetory(string directoryPath, string fileType)
        {
            
        }

        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        }
    }
}
