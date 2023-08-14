// See https://aka.ms/new-console-template for more information
using ChallengeMe.DataStorage;
using ChallengeMe.Services;

do
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Registration");
    Console.WriteLine("2. Login");

    string choice = Console.ReadLine();

    bool AreLogined = false;

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
                var data = new Authentication();

                AreLogined = true;

                Console.WriteLine("Enter your login and password:");

                data.Authenticate(Console.ReadLine(), Console.ReadLine());
            }
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    if(AreLogined)
    {
        Console.WriteLine("If you want logoff enter 'Exit'");
                string Comand = Console.ReadLine();

                if (Comand == "Exit")
                {
                    var exiting = new Exiting();
                    exiting.Exit(Comand);
                }
    }

} while (true);






