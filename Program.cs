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
            //UC2
            Console.WriteLine("please enter LastName");
            string LastName = Console.ReadLine();
            bool Lname = regexProb.validateLastname(LastName);
            if (Lname)
                Console.WriteLine("Lastname Matched");
            else
                Console.WriteLine("LastName not matched");
            //UC3
            Console.WriteLine("please enter The EmailAdress: ");
            string Emailaddress = Console.ReadLine();

            bool Email = regexProb.validateEmailAddress(Emailaddress);
            if (Email)
                Console.WriteLine("Email Matched");
            else
                Console.WriteLine("Email not matched");
            //UC4
            Console.WriteLine("please enter PhoneNumber");
            string Phonenumber = Console.ReadLine();
            bool PhnNO = regexProb.validatephonenumber(Phonenumber);
            if (PhnNO)
                Console.WriteLine("Phn NO Matched");
            else
                Console.WriteLine("Phn No not matched");

            Console.WriteLine("please enter PassWord: ");
            string Password = Console.ReadLine();
            bool Pwd = regexProb.validatepassword(Password);
            if (Pwd)
                Console.WriteLine("Password Matched");
            else
                Console.WriteLine("Password not matched");
        }
    }
}
