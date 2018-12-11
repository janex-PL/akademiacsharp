using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_03
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(10);
            Console.WriteLine(s1.GetObwod());
            Console.WriteLine(s1.Area);
            Figura f1 = new Rectangle(10,20);
            Console.WriteLine(f1.GetObwod());
            Console.WriteLine(f1.Area);

        }
    }
}
