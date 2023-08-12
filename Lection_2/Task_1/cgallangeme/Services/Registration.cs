using ChallengeMe.DataStorage;
using cgallangeme.Services.Interface;

namespace ChallengeMe.Tests
{
    public class Register : IRegistrationService
    {
        public void Registration(string String, string _String)
        {
            Users.UsersList.Append(new User(String, _String));

        }
    }
}