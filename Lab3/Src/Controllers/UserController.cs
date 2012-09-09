using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Src.Models;

namespace Src.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (loginViewModel.Username == "yngvebn")
            {
                FormsAuthentication.SetAuthCookie(loginViewModel.Username, true);
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
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ViewResult MyPage()
        {
            throw new NotImplementedException();
        }
    }
}
