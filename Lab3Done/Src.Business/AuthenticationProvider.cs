using System.Web.Security;

namespace Src.Business
{
    public class AuthenticationProvider : IAuthenticationProvider
    {
        public bool Validate(string username, string password)
        {
            return username.Equals("yngve");
        }

        public void Login(string username)
        {
            FormsAuthentication.SetAuthCookie(username, true);
        }
        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}