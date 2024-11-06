using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class Select
    {
        public Select()
        {
            var numbers = Enumerable.Range(1, 4);
            var squares = numbers.Select(x => x * x);
            //Console.WriteLine(squares);

            string sentence = "This is a new sentence";
            var wordLengths = sentence.Split().Select(x => x.Length);

            //Console.WriteLine(wordLengths);

            var wordsWithLength = sentence.Split()
                .Select(w => new { word = w, length = w.Length} );

            Console.WriteLine(wordsWithLength);

            Random rand = new Random();
            var randomNumbers = Enumerable.Range(1, 10).Select(_ => rand.Next(10));

            //Console.WriteLine(randomNumbers);

            var sequences = new[] { "red,green,blue", "orange", "white,pink" };
            //SelectMany = Convert each array elements into one list, instead of 3 arrays with elements each one
            var allWords = sequences.SelectMany(s => s.Split(','));

            string[] objects = { "house", "car", "byke" };
            string[] colors = { "red", "green", "gray" };
            //var pairs = colors.SelectMany(_ => objects, (c, o) => $"{c} {o}");
            var pairs = colors.SelectMany(_ => objects, (c, o) => new {Color = c, @Object = o});
        }
    }
}
