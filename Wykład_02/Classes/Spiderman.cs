using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wykład_02.Enums;

namespace Wykład_02.Classes
{
    class Spiderman : Human
    {
        public float WebAmount { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }
        public FavouriteColor FavColor;
        public Spiderman(int age, int height, int weight, string firstName, string lastName, float webAmount, int speed, int power, FavouriteColor color) : base(age, height, weight, firstName, lastName)
        {
            WebAmount = webAmount;
            Speed = speed;
            Power = power;
            FavColor = color;
        }
    }
}
