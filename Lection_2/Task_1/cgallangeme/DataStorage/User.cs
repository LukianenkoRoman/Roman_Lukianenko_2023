internal class User
{
    string Name; string Password;
    public User(string String, string _String)
    {
        Password = String;
        Name = _String;
    }

    public string GetName()
    {
        return Password;
    }
    public string GetPassword()
    {
        return Name;
    }
}

