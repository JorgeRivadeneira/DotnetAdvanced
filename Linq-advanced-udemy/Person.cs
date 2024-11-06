using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_advanced_udemy
{
    public class Person
    {
        public string FirstName, MiddleName, LastName;

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public IEnumerable<string> Names
        {
            get
            {
                yield return FirstName;
                yield return MiddleName;
                yield return LastName;
            }
        }
    }
}
