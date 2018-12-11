using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_05
{
    public delegate void Dzialanie(int x, int y);

    public delegate void Wypisz(string wiadomosc);
    //public class System
    //{
    //    public delegate void Log(string wiadomosc);

    //    private Log _wyslijLog;

    //    public void DodajCallback(Log funkcja)
    //    {
    //        _wyslijLog += funkcja;
    //    }

    //    public void WypiszLog(string wiadomosc)
    //    {
    //        _wyslijLog(wiadomosc);
    //    }
    //}
    public class Rownanie
    {
        public delegate void WynikDelegata(float liczba);
        public event WynikDelegata Parzysta;

        public float Dzielenie(int x, int y)
        {
            float z = x / y;
            if (z % 2 == 0)
            {
                Parzysta(z);
            }
            return z;
        }
    }

    public class Matma2
    {
        public int Dodawanie(int x, int y)
        {
            return x + y;
        }
    }
    class Program
    {
        static void CallbackLog(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
            Console.WriteLine("Została wywołana funkcja zwrotna");
        }

        static void Info(int x, int y, Wypisz wypisz)
        {
            wypisz(String.Format("Pierwsza liczba {0}, druga liczba {1}", x, y));
        }

        static void WypiszNaKonsoli(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }

        static void WypiszLiczbeParzysta(float liczba)
        {
            Console.WriteLine("Liczba parzysta to: " + liczba);
        }

        static void Main(string[] args)
        {

            Rownanie rownanie = new Rownanie();

            rownanie.Parzysta += WypiszLiczbeParzysta;

            rownanie.Dzielenie(4, 2);







            //Matma matma = new Matma();

            //Dzialanie dzialanie = new Dzialanie(matma.Dodaj);

            //dzialanie += matma.Dodaj;
            //dzialanie += matma.Odejmij;
            //dzialanie -= matma.Dodaj;

            //dzialanie(5, 5);
            //dzialanie.Invoke(5,5);
            //System system = new System();
            //system.DodajCallback(CallbackLog);
            //system.WypiszLog("CallbackLogi");
            //Wypisz wypisz = new Wypisz(WypiszNaKonsoli);

            //Info(5, 10, wypisz);

            //Matma2 matematyka = new Matma2();
            //Func<int, int, int> dodawanie = matematyka.Dodawanie;

            //Console.WriteLine(dodawanie(4,6));

            //Action<string> wypisz = System.Console.WriteLine;

            //wypisz("EKA.NET");



        }
    }
}
