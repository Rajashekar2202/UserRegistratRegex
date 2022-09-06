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