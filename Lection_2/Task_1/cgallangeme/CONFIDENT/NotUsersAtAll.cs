namespace ChallengeMe.CONFIDENT
{
    internal class NotUsersAtAll
    {
        public NotUsersAtAll(string login, string password)
        {

            var ah = new NotUser(login, password);
            
            hohoho[0] = ah;

            return;
        }
        public static NotUser[] hohoho = new NotUser[1];
    }

    internal class NotUser
    {
        string NotName; string notPess123word;
        public NotUser(string String, string _String)
        {
            notPess123word = String;
            NotName = _String;
        }

        public string GetNotName()
        {
            return notPess123word;
        }
        public string GetNotNumbers()
        {
            return NotName;
        }
    }
}


