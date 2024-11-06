using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class QuantifierOperations
    {
        public QuantifierOperations()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Are all numbers > 0 ?" + numbers.All(x => x > 0));
            Console.WriteLine("Are all odd numbers ?" + numbers.All(x => x % 2 == 1));
            Console.WriteLine("Are any odd number ?" + numbers.Any(x => x % 2 == 1));
            Console.WriteLine("Are there the 5 number ?" + numbers.Contains(5));
        }
    }
}
