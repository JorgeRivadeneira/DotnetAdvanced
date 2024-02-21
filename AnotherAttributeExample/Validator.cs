using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAttributeExample
{
    public static class Validator
    {
        public static bool ValidateAge(Person person)
        {
            var property = person.GetType().GetProperty("Age");
            var attribute = property.GetCustomAttribute<RangeAttribute>();

            if (attribute != null)
            {
                return person.Age >= attribute.Minimum && person.Age <= attribute.Maximum;
            }

            return true;
        }
    }
}
