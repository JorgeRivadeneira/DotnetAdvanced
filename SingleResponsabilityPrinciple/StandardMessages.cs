using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You didn't give us a valide {fieldName}!");
        }
    }

}
