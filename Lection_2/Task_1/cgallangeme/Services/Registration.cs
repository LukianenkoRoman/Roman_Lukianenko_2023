using ChallengeMe.Userservices;
using ChallengeMe.Services;

namespace ChallengeMe.Tests
{
    public class FirstTimeInTheFridge : IUserService
    {
        public void Logining(string String, string _String)
        {
            throw new NotImplementedException();
        }

        public void Registration(string String, string _String)
        {
            Users.data.Append(new User(String, _String));

        }

        public void Exiting(string String)
        {
            throw new NotImplementedException();
        }
    }
}