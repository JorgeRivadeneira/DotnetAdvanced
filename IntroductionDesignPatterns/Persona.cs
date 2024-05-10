using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionDesignPatterns
{
    internal class Persona
    {
        public Persona(string name, int age, string nationality)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }

        public string Show()
        {
            return $"Name: {Name}, Age: {Age}, Nationality: {Nationality}";
        }

    }
}
