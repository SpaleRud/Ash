namespace Ash
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public bool CheckUser()
        {
            return true;
        }
    }
}