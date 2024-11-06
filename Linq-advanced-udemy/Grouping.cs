using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class Grouping
    {
        public Grouping()
        {
            var people = new List<People>()
            {
                new People{Name = "Adam", Age = 36},
                new People{Name = "Boris", Age = 18},
                new People{Name = "Claire", Age = 36},
                new People{Name = "Adam", Age = 20},
                new People{Name = "Jack", Age = 20},
                new People{Name = "Adam", Age = 20},
            };

            var byName = people.GroupBy(p => p.Age < 30);
            var byAgeNames = people.GroupBy(p => p.Age, P => P.Name); 

            foreach (var item in byAgeNames)
            {
                Console.WriteLine($"These people are {item.Key} years old");
                foreach(var name in item)
                {
                    Console.WriteLine($" -{name}");
                }
            }

        }
    }
}
