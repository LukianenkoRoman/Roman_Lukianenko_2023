using cgallangeme.Services.Interface;
using ChallengeMe.DataStorage;

namespace ChallengeMe.Services
{
    public class Authentication : ILoginService
    {
        public void Authenticate(string usname, string password)
        {
            User UserEx = null;
            bool UsersData = false;

            foreach (var user in Users.UsersList)
            {
                if (user.GetName() == usname && user.GetPassword() == password)
                {
                    UserEx = user;
                    UsersData = true;
                }
                break;
            }
            if (UsersData)
            {
                Console.WriteLine("You have been authenticated", UserEx.GetName);
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("Uncorect data");
            }
        }

    }
}