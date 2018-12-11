using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Janek", "Bartek", "Janusz", "Grażyna"};
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            if (students.Contains("Janek") && students.Contains("Bartek"))
            {
                Console.WriteLine("Jest Bartek i Janek");
            }

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            
            getStudents(students);
            int treeNumber = Convert.ToInt32(Console.ReadLine());
            showTree(treeNumber);
            Console.ReadKey();
        }

        public static void getStudents(string[] studentsTab)
        {
            foreach (var item in studentsTab)
            {
                Console.WriteLine(item);
            }
        }

        public static void showTree(int treeHeight)
        {
            for (int i = 0; i < treeHeight; i++)
            {
                string treeLine = "";
                for (int j = 0; j<treeHeight-i; j++)
                {
                    treeLine += " ";
                }
                for (int j = 0; j < 2*i+1; j++)
                {
                    treeLine += "*";
                }
                Console.WriteLine(treeLine);
            }
        }
    }
}
