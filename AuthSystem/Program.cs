using System;

class Program
{
    static void Main()
    {
        AuthService authService = new AuthService();

        while (true)
        {
            Console.WriteLine("\n1. Sign Up\n2. Sign In");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine() ?? ""; 

            // If the choice is not "1" or "2", break the loop
            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("Invalid option! Exiting program...");
                break;
            }

            Console.Write("Enter Username: ");
            string username = Console.ReadLine() ?? ""; 
            Console.Write("Enter Password: ");
            string password = Console.ReadLine() ?? ""; 

            if (choice == "1")
                authService.SignUp(username, password);
            else if (choice == "2")
                authService.SignIn(username, password);
        }
    }
}
