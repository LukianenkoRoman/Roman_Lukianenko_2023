using cgallangeme.Services.Interface;
using ChallengeMe.DataStorage;

namespace ChallengeMe.Services
{
    public class Authentication : ILoginService
    {
        public void Authenticate(string String, string _String)
        {
            User[] notUsers = new User[2];
            bool UsersData = false;

            foreach (var user in Users.UsersList)
            {
                if (user.GetName() == String && user.GetNumbers() == _String)
                {
                    notUsers[0] = user;
                    UsersData = true;
                }
            }
            if (UsersData)
            {
                Console.WriteLine("You have entered the fridge", notUsers[0]);
            }
            else
            {
                Console.WriteLine("Your fridge has benn lohed");
            }
        }

    }
}