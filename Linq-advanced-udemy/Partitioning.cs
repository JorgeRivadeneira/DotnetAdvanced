using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class Partitioning
    {
        public Partitioning()
        {
            var numbers = new[] { 3, 3, 2, 2, 1, 1, 2, 2, 3, 3 };
            Console.WriteLine(numbers.Skip(2).Take(6));
            Console.WriteLine(numbers.SkipWhile(x => x == 3));
            Console.WriteLine(numbers.TakeWhile(x => x > 1));
        }
    }
}
