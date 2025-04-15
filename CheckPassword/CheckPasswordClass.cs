namespace CheckPassword
{
    public class CheckPasswordClass
    {
        public static int CheckPassword(string password)
        {
            if (password.Length >= 1) return 1;
            return 0;
        }
    }
}