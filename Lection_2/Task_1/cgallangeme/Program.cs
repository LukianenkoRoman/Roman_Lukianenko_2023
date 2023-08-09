// See https://aka.ms/new-console-template for more information
using ChallengeMe.CONFIDENT;
using ChallengeMe.Tests;
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

                var food = new NotUsersAtAll(Console.ReadLine(), Console.ReadLine());
            }
            break;

        case "2":
            {
                var data = new WelcomeToTheFridge();

                Console.WriteLine("Enter your login and password:");

                data.EnterTheFridge(Console.ReadLine(), Console.ReadLine());


                Console.WriteLine("If you want logoff enter 'Exit'");

                data.UnregisterFood(Console.ReadLine());
            }
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
} while (true);






