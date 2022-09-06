namespace UserRegistration1
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

            Console.WriteLine("Enter Mobile Number");
            string mobileNumber = Console.ReadLine();

            User d = new User();
            bool val3 = d.MobileNumber(mobileNumber);

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            User e = new User();
            bool val4 = e.Password(password);

            Console.WriteLine("Enter Sample Email");
            string email = Console.ReadLine();

            User f = new User();
            bool val5= e.Email(email);

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

            if (val3)
            {
                Console.WriteLine("Valid MobileNumber");
            }
            else
            {
                Console.WriteLine("Invalid MobileNumber");
            }

            if (val4)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Passward");
            }
        }
    }
}