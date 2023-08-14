using ChallengeMe.DataStorage;
using cgallangeme.Services;

namespace ChallengeMe.Services
{
 public class Exiting : IExitService
    {
        public void Exit(string Exit)
        {
            if (Exit == "Exit")
            {
                Console.WriteLine("You have been logoff");
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("Uncorect comand");
            }
        }
    }
}
