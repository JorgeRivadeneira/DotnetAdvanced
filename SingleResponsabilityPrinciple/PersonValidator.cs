using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //checks if first and last names are valid
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError("First Name");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError("Last Name");
                return false;
            }
            return true;
        }
    }
}
