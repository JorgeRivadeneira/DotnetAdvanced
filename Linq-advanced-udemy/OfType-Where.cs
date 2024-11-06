using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class OfType_Where
    {
        public OfType_Where()
        {
            var numbers = Enumerable.Range(1, 10);
            var evenNumbers = numbers.Where(x => x % 2 == 0);
            //Console.WriteLine(evenNumbers);

            var oddNumbers = numbers.Select(x => x*x).Where(y => y % 2 == 1);
            Console.WriteLine(oddNumbers);

            object[] values = { 1, 2.5, 3, 4.56 };
            //Console.WriteLine(values.OfType<double>());

            int[] listNumebers = { 1, 2,3,4,5,6,7,8,9,10};
            var result = MyFilter(listNumebers);
            Console.WriteLine(result);
        }

        public static IEnumerable<int> MyFilter(IEnumerable<int> input)
        {
            // todo
            var evenNumbers = input.Where(x => x % 2 == 1).Select(x => x * x).Where(x => x < 50);
            return evenNumbers;
        }
    }
}
