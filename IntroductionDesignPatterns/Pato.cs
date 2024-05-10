using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionDesignPatterns
{
    internal class Pato : IVolador, ICaminador
    {
        public void Camina()
        {
            Console.WriteLine("Pato vuela");
        }

        public void Vuela()
        {
            Console.WriteLine("Pato camina");

        }
    }
}
