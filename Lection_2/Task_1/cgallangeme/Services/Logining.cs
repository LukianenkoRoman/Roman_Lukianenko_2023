using ChallengeMe.Userservices;
using ChallengeMe.Services;

namespace ChallengeMe.Tests
{
    public class WelcomeToTheFridge : IUserService
    {
        public void Logining(string String, string _String)
        {
            User[] notUsers = new User[2];
            bool UsersData = false;

            foreach (var user in Users.data)
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

        public void Registration(string String, string _String)
        {
            throw new NotImplementedException();
        }

        public void Exiting(string String)
        {
            if (String == "Exit")
                Users.data[0] = null;
        }
    }
}