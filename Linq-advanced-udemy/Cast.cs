using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public  class Cast
    {
        public Cast()
        {

            var list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //Console.WriteLine(list.Select(x => (int)x).sum());
            Console.WriteLine(list.Cast<int>().Average());

            var numbers = Enumerable.Range(1, 10);
            var arr = numbers.ToArray();
            var dict = numbers.ToDictionary(i => (double)i / 10, i => i % 2 == 0);
            Console.WriteLine(dict);

            var arr2 = new int[] { 1, 2, 3 };
            var arr3 = arr2.AsEnumerable();
        }
    }
}
