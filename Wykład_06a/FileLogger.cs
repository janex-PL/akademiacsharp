using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_06a
{
    public class FileLogger
    {
        public string filePath { get; set; }

        public FileLogger()
        {
            var projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            filePath = $@"{projectDir}\Orders.txt";
        }

        public void LogOrder(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath, append: true))
            {
                streamWriter.WriteLine(message);
            }
        }

        public void PrintAllOrders()
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
            }
        }

    }
}
