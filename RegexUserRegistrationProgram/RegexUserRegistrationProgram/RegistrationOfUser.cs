﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationProgram
{
    public class RegistrationOfUser
    {
        public void UserRegistration()
        {
            Regex firstName = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine("Enter your first Name :");
            string firstname = Console.ReadLine();
            if (firstName.IsMatch(firstname))
            {
                Console.WriteLine("Your Name is :" + firstname);
            }
            else
            {
                Console.WriteLine("Your entered name is in invalid pattern");
            }

            Regex LastName = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine("Enter your Last Name:");
            string lastname = Console.ReadLine();
            if (LastName.IsMatch(lastname))
            {
                Console.WriteLine("Your last Name is:" + lastname);
            }
            else
            {
                Console.WriteLine("Your entered last name is in invalid pattern");
            }
            Regex EmailId = new Regex("^[a-z]{1,}[.][a-z]{1,}[0-9]{0,}[@][a-z]{1,}[.][a-z]{1,3}[.]{0,}[a-z]{0,2}$");

            Console.WriteLine("Enter your EmailId: ");
            string emailid = Console.ReadLine();
            if (EmailId.IsMatch(emailid))
            {
                Console.WriteLine("Your emailId is:" +emailid);
            }
            else
            {
                Console.WriteLine("Your entered emailId is in invalid pattern");
            }

        }
    }
}
