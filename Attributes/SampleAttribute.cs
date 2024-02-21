using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute: Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }

    [Sample(Name = "Beta", Version =1)]
    public class Test
    {
        //[Sample]
        public int IntValue { get; set; }

        //[Sample]
        public void Method() { }
    }

    public class NoAttribute { }
}
