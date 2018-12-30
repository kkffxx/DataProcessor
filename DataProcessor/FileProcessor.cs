using System.IO;

namespace DataProcessor
{
    internal class FileProcessor
    {
        public string InputFilePath { get; }

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public void Process()
        {
            System.Console.WriteLine($"Begin process of {InputFilePath}");
            if (!File.Exists(InputFilePath))
            {
                System.Console.WriteLine($"ERROR: file {InputFilePath} does not exist.");
            }
            else
            {
                System.Console.WriteLine("Press y to create a copy");
                if (System.Console.ReadLine() == "y")
                    File.Move(InputFilePath, Path.GetDirectoryName(InputFilePath) + "\\MOVED" + Path.GetFileName(InputFilePath));
            }

        }

        public void CreateDirectory(string dirName)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(InputFilePath) + "\\" + dirName);
        }
    }
}