using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAttributeExample
{
    //public class Person
    //{
    //    private int _age;
    //    public string Name { get; set; }


    //    [Range(18, 64)]
    //    public int Age
    //    {
    //        get { return _age; }
    //        set
    //        {
    //            var property = this.GetType().GetProperty("Age");
    //            var attribute = property.GetCustomAttribute<RangeAttribute>();
    //            if (value < attribute.Minimum || value > attribute.Maximum)
    //            {
    //                throw new ArgumentOutOfRangeException($"The Age is out of the Range " + value);
    //            }
    //        }
    //    }

    //}

    public class Person
    {

        [Range(18, 64)]
        public int Age { get; set; }
        public string Name { get; set; }

    }
}
