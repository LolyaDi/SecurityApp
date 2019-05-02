namespace SecurityApp.Services
{
    public class SecurityHasher
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string passwordCandidate, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(passwordCandidate,hashedPassword);
        }
    }
}
