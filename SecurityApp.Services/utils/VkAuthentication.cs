using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;

namespace SecurityApp.Services.utils
{
    public class VkAuthentication : IAuthentication
    {
        public string AuthorizeUser(string login, string password)
        {
            var api = new VkApi();

            string result = "Success!";

            try
            {
                api.Authorize(new ApiAuthParams
                {
                    ApplicationId = 6968848,
                    Login = login,
                    Password = password,
                    Settings = Settings.All
                });
            }
            catch (VkApiAuthorizationException)
            {
                result = "Login or password isn't correct!";
            }
            catch (VkApiException)
            {
                result = "Error!!! Try again!";
            }

            return result;
        }
    }
}
