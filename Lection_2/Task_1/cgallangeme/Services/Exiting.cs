using ChallengeMe.DataStorage;
using cgallangeme.Services;

namespace ChallengeMe.Services
{
 public class Exiting : IExitService
    {
        public void Exit(string String)
        {
            if (String == "Exit")
            Users.UsersList[0] = null;
        }
    }
}
