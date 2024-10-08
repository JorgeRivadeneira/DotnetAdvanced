﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple.Before
{
    public class Before
    {
        public Before()
        {
            Console.WriteLine("Welcome to my application");

            Person user = new Person();

            Console.WriteLine("What is your first name?");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            user.LastName = Console.ReadLine();

            //checks if first and last names are valid
            if (string.IsNullOrEmpty(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name");
                Console.ReadLine();
                return;
            }

            //Create a user name for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1).ToLower()}{user.LastName.ToLower()}");
            Console.ReadLine();
        }

    }
}
