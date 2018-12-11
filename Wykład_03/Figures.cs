using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Wykład_03
{
   public abstract class Figura
   {
       public abstract int Area { get; set; }
       public abstract int GetObwod();
   }

    public class Square : Figura
    {
        public int a { get; set; }
        public sealed override int Area { get; set; }
        public override int GetObwod()
        {
            return 4 * a;
        }

        public Square(int side)
        {
            a = side;
            Area = side * side;
        }
    }

    public class Rectangle : Figura
    {
        public int A { get; set; }
        public int B { get; set; }
        public sealed override int Area { get; set; }
        public override int GetObwod()
        {
            return 2 * A + 2 * B;
        }

        public Rectangle(int sideA, int sideB)
        {
            A = sideA;
            B = sideB;
            Area = A * B;
        }
    }

    public class Trapeze : Figura
    {
        public int BaseA { get; set; }
        public int BaseB { get; set; }
        public int ShoulderA { get; set; }
        public int ShoulderB { get; set; }
        public int Height { get; set; }
        public sealed override int Area { get; set; }
        public override int GetObwod()
        {
            return BaseA + BaseB + ShoulderA + ShoulderB;
        }

        public Trapeze(int a, int b, int c, int d,int e)
        {
            BaseA = a;
            BaseB = b;
            ShoulderA = c;
            ShoulderB = d;
            Height = e;
            Area = (BaseA + BaseB) * Height / 2;
        }
    }
}
