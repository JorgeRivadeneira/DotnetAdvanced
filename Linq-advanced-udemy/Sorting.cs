using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class Sorting
    {
        public Sorting()
        {
            var rand = new Random();
            var randomValues = Enumerable.Range(1, 10)
                .Select(i => rand.Next(10) - 5)
                .Distinct();

            var csvString = new Func<IEnumerable<int>, string>(values =>
            {
                return string.Join(",", values.Select(v => v.ToString()).ToArray());
            });

            Console.WriteLine(csvString(randomValues));
            Console.WriteLine(csvString(randomValues.OrderBy(x => x)));
            Console.WriteLine(csvString(randomValues.OrderByDescending(x => x)));


            //More complicated:
            var people = new List<People>()
            {
                new People{Name = "Adam", Age = 36},
                new People{Name = "Boris", Age = 18},
                new People{Name = "Claire", Age = 36},
                new People{Name = "Adam", Age = 20},
                new People{Name = "Jack", Age = 20},
                new People{Name = "Adam", Age = 20},
            };
            Console.WriteLine();

            Console.WriteLine(
                string.Join("\n", people
                                    .OrderBy(x => x.Age)
                                    .ThenByDescending(x => x.Name)
                                    .Select(x => $"{x.Name} => {x.Age}")
            ));

            string s = "This is a test";
            Console.WriteLine(new string(s.Reverse().ToArray()));
        }
    }
}
