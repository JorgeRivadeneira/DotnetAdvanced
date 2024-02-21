using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAttributeExample
{
    public class RangeAttribute : Attribute
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public RangeAttribute(int min, int max)
        {
            Minimum = min;
            Maximum = max;
        }
    }
}
