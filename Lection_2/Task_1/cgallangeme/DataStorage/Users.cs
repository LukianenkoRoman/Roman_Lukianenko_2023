namespace ChallengeMe.DataStorage
{
    internal class Users
    {
        private static List<User> usersList = new List<User>();

        public Users(string login, string password)
        {
            User userData = new User(login, password);
            
            usersList.Add(userData);
        }

        public static List<User> UsersList => usersList;
    }
}


