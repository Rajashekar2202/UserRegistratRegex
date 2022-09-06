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
            if (val)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
    }
}