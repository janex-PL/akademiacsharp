using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace Wykład_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Console.WriteLine(projectDir);
            string path = $@"{projectDir}\userList.csv";

            var users = new List<User>
            {
                new User {Name = "Bob", Surname = "Smith"},
                new User {Name = "Bobby", Surname = "Smithyy"},
            };

            using (StreamWriter streamWriter = File.CreateText(path))
            {
                var writer = new CsvWriter(streamWriter);
                writer.Configuration.RegisterClassMap<UserMap>();
                writer.WriteRecords(users);
            }

















            //DirectoryInfo current = new DirectoryInfo(".");

            //var projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //Console.WriteLine(projectDir);
            //string path = $@"{projectDir}\checkList.txt";

            //List<string> checkList = new List<string>
            //{
            //    "Zrobic obiad",
            //    "Przygotowac sie do kolokwium",
            //    "Zabic sie"
            //};

            //File.WriteAllLines(path,checkList);

            //foreach (var x in File.ReadAllLines(path))
            //{
            //    Console.WriteLine(x);
            //}


            //StreamWriter streamWriter = new StreamWriter(path, append:true);
            //streamWriter.WriteLine("Elo siema");
            //streamWriter.Dispose();

            //using (StreamReader streamReader = new StreamReader(path))
            //{
            //    string line;

            //    while ((line = streamReader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
        }
    }
}
