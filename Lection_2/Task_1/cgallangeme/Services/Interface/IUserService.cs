namespace cgallangeme.Services.Interface
{
    internal interface IUserService
    {
        void AddUser(string username, string password);
        void DeleteUser(string username, string password);
        User? Authenticate (string username, string password);
    }
}
