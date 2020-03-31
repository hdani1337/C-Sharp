namespace Beadandó_200417
{
    public class User
    {
        public string username { get; }
        public string password { get; }

        public User()
        {
            this.username = null;
            this.password = null;
        }

        public User(string line)
        {
            this.username = line.Split(';')[0];
            this.password = line.Split(';')[1];
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}