using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAttribute
{
    [Serializable]
    [Test("Popcorn", Quantity = 10)]
    [Test("KFC", Quantity = 2)]
    internal class AttributeExample
    {
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class TestAttribute: Attribute
    {
        private readonly string _name;
        public int Quantity;

        public TestAttribute(string name)
        {
            _name = name;
            Console.WriteLine(name);
        }

        public string Name => _name;
    }
}
