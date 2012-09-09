using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Src.Business;
using Src.Models;

namespace Src.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthenticationProvider _authenticationProvider;
        //
        // GET: /User/

        public UserController(IAuthenticationProvider authenticationProvider)
        {
            _authenticationProvider = authenticationProvider;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (_authenticationProvider.Validate(loginViewModel.Username, loginViewModel.Password))
            {
                _authenticationProvider.Login(loginViewModel.Username);
                if (!string.IsNullOrEmpty(returnUrl))
                    return Redirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError("Username", "Not valid");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            _authenticationProvider.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
