using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Src.Business
{
    public interface IAuthenticationProvider
    {
        bool Validate(string username, string password);
        void Login(string username);
        void Logout();
    }
}
