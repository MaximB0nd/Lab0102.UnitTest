namespace CheckPassword
{
    public class CheckPasswordClass
    {
        public int CheckPassword(string password)
        {
            int rate = 0;
            if (password.Length <= 0) return 0;
            
            if (password.Length >= 8) rate++;

            foreach (var t in password)
            {
                if (t < 'a' || t > 'z') continue;
                rate++; 
                break;
            }
            foreach (var t in password)
            {
                if (t < 'A' || t > 'Z') continue;
                rate++; 
                break;
            }

            foreach (var t in password)
            {
                if (!char.IsDigit(t)) continue;
                rate++; 
                break;
            }

            foreach (var t in password)
            {
                if (char.IsLetterOrDigit(t)) continue;
                rate++;
                break;
            }

            return rate;
        }
        public bool IsSafe(string password)
        {
           return CheckPassword(password) >= 5;
        }
    }
}