using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_02.Classes
{
    class Human
    { 
        public int Age { get; set; }            // Przy tworzeniu samej właściwości, kompilator sam tworzy pole prywatne
        public int Height { get; set; }          // niejawnego pola nie można jednak używać wewnątrz kodu
        public int Weight { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public Human() // przy deklaracji konstruktora przyjmującego argumenty jeśli trzeba użyć domyślnego konstruktora,
        {
        }                     
        // to trzeba go wtedy jawnie zadeklarować

        public Human(int age, int weight)
        {
            Age = age;
            Weight = weight;
        }

        public Human(int age, int height, int weight, string firstName, string lastName)
        {
            Age = age;
            Height = height;
            Weight = weight;
            FirstName = firstName;
            LastName = lastName;
        }

        public void smileyFace()
        {
            string _message;
            if (Age == null)
                _message = "??? ??? ???";
            else if (Age < 20)
                _message = ";) ;) ;)";
            else
                _message = "I want to die pls kill me right now";
            Console.WriteLine(_message);
        }
    }
}
