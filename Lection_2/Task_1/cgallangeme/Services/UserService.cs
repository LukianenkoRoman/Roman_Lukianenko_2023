using cgallangeme.Services.Interface;
using ChallengeMe.DataStorage;

namespace cgallangeme.Services;

internal class UserService : IUserService
{
    public void AddUser(string username, string password)
    {
        DBStorage.UsersList.Add(new User(username, password));
    }

    public User? Authenticate(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            return null;
        }

        var user = DBStorage.UsersList.FirstOrDefault(x => x.GetName() == username && x.GetPassword() == password);

        return user;
    }

    public void DeleteUser(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            var user = DBStorage.UsersList.FirstOrDefault(x => x.GetName() == username && x.GetPassword() == password);

            if (user is not null)
            {
                DBStorage.UsersList.Remove(user);
            }
        }

    }

}
