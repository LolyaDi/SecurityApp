namespace SecurityApp.Services
{
    public interface IAuthentication
    {
        string AuthorizeUser(string login, string password);
    }
}
