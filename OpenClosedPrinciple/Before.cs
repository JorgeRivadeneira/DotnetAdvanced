using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Before
{
    public class Before
    {
        public Before()
        {

        }

        public static void Init()
        {
            var apple = new Producto("Apple", Color.Green, Size.Small);
            var tree = new Producto("Tree", Color.Green, Size.Large);
            var house = new Producto("Apple", Color.Blue, Size.Large);

            Producto[] products = { apple, tree, house };
            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
        }

    }

    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Producto
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Producto(string name, Color color, Size size)
        {
            if (name == null) throw new ArgumentNullException(paramName: nameof(name));
            name = Name;
            color = Color;
            size = Size;
        }

    }

    public class ProductFilter
    {
        public IEnumerable<Producto> FilterBySize(IEnumerable<Producto> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size) yield return p;
            }
        }

        public IEnumerable<Producto> FilterByColor(IEnumerable<Producto> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color) yield return p;
            }
        }

        public IEnumerable<Producto> FilterBySizeAndColor(IEnumerable<Producto> products, Size size, Color color)
        {
            foreach (var p in products)
            {
                if (p.Size == size && p.Color == color) yield return p;
            }
        }
    }

}
