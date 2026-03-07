internal class Program
{
    private static void Main(string[] args)
    {
        Jumpstart();
    }

    static void Jumpstart()
    {
        do // Simple Menu must convert to UI
        {
            Console.WriteLine("1. Login Bettor\n" +
            "2. Register Bettor\n" +
            "3. Exit\n" +
            "Enter Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Login();
                break;
                case "2":
                    Register();
                break;
                case "3":
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Please enter a valid input!");
                break;
            }

        } while(true);
    }

    static void Login()
    {
        //Login here
    }

    static void Register()
    {
        //Register here
    }
}

