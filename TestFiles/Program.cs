using System;
using System.IO;
using System.Linq;

namespace TestFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filesPath = Directory.GetFiles(path);

            filesPath.ToList().ForEach(x => Console.WriteLine(x));

            filesPath.ToList().ForEach(x =>
            {
                Console.WriteLine(Path.GetExtension(x));
            });

            var fileInfo = new FileInfo("Program.exe");
        }
    }
}
