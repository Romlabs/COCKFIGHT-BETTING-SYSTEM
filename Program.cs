internal class Program
{
    private static void Main(string[] args)
    {
        Jumpstart();
    }

    static void Jumpstart()
    {
        do
        {
            Console.WriteLine("1. Login Bettor\n" +
            "2. Register Bettor\n" +
            "3. Exit\n" +
            "Enter Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":

                break;
                case "2":

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
}

