namespace ChallengeMe.DataStorage
{
    internal class Users
    {
        public Users(string login, string password)
        {
            var UserData = new User(login, password);

            UsersList[0] = UserData;

            return;
        }
        public static User[] UsersList = new User[1];
    }

}


