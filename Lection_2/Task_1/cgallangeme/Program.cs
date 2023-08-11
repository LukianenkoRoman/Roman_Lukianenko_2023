// See https://aka.ms/new-console-template for more information
using ChallengeMe.Userservices;
using ChallengeMe.Services;

do
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Registration");
    Console.WriteLine("2. Login");

    string choice = Console.ReadLine();

    switch (choice)
    {

        case "1":
            {
                Console.WriteLine("Register your login and password:");

                var user = new Users(Console.ReadLine(), Console.ReadLine());
            }
            break;

        case "2":
            {
                var data = new Logining();

                Console.WriteLine("Enter your login and password:");

                data.Enter(Console.ReadLine(), Console.ReadLine());


                Console.WriteLine("If you want logoff enter 'Exit'");

                data.Exit(Console.ReadLine());
            }
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
} while (true);






