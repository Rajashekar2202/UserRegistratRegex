﻿namespace UserRegistration1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            User a = new User();
            bool val = a.FirstName(firstName);

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            User b = new User();
            bool val1 = b.LastName(lastName);

            Console.WriteLine("Enter Email Id");
            string emailId = Console.ReadLine();

            User c = new User();
            bool val2 = c.EmailId(emailId);

            if (val)
            {
                Console.WriteLine("Valid FirstName");
            }
            else
            {
                Console.WriteLine("Invalid FirstName");
            }

            if (val1)
            {
                Console.WriteLine("Valid LastName");
            }
            else
            {
                Console.WriteLine("Invalid LastName");
            }

            if (val2)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }

        }
    }
}