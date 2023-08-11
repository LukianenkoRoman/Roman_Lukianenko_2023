namespace ChallengeMe.Userservices
{
    internal class Users
    {
        public Users(string login, string password)
        {

            var ah = new User(login, password);

            data[0] = ah;

            return;
        }
        public static User[] data = new User[1];
    }

}


