internal class User
{
    string _name; 
    string _password;
    
    public User(string login, string password)
    {
        _name = login;
        _password = password;
    }

    public string GetName()
    {
        return _name;
    }
    
    public string GetPassword()
    {
        return _password;
    }
}

