using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Src.Models;

namespace Src.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        [Authorize]
        public ActionResult Secret()
        {
            return View();
        }
    }
}
