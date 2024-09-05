using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            //Create a user name for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1).ToLower()}{user.LastName.ToLower()}");
        }
    }
}
