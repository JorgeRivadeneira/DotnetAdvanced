using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class SetOperators
    {
        public SetOperators()
        {
            string word1 = "hellooooooo";
            string word2 = "help";

            //Console.WriteLine(word1.Distinct());

            var lettersInBoth = word1.Intersect(word2);
            Console.WriteLine(lettersInBoth);

            Console.WriteLine(word1.Union(word2));

            Console.WriteLine(word1.Except(word2));
        }
    }
}
