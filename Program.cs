namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To User Registeration Problem");
            UserDetials regexProb = new UserDetials();

            Console.WriteLine("please enter Firstname");
            string FirstName = Console.ReadLine();

            bool Fname = regexProb.validateFirstname(FirstName);
            if (Fname)
                Console.WriteLine("firstname Matched");
            else
                Console.WriteLine("FirstName not matched");
        }
    }
}
