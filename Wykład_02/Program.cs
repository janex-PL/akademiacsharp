using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wykład_02.Classes;
using Wykład_02.Enums;

namespace Wykład_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Human man = new Human(25,80,180,"Peter","Parker");
            Human women = new Human(18, 75);
            Human nomen = new Human();


            man.smileyFace();
            women.smileyFace();
         // nomen.smileyFace();

            Spiderman spidie = new Spiderman(25, 80, 180, "Spider", "Man", 100, 80, 100, FavouriteColor.blue);
            Console.WriteLine("Spidermans' age = " + spidie.Age.ToString());
            ChangeSpidieAge(spidie,50);
            Console.WriteLine("Spidermans' age = " + spidie.Age.ToString());

            FavouriteColor colors = FavouriteColor.white;
            switch (colors)
            {
                case FavouriteColor.red:
                    break;
                case FavouriteColor.white:
                    break;
                case FavouriteColor.blue:
                    break;
                case FavouriteColor.black:
                    break;
                case FavouriteColor.brown:
                    break;
                case FavouriteColor.pink:
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

        static void ChangeSpidieAge(Spiderman spidey, int age)
        {
            spidey.Age = age;
        }
    }
}
