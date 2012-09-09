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
            MainViewModel mainViewModel = new MainViewModel()
                {
                    Message = "Dette er en beskjed",
                    Now = DateTime.Now
                };
            return View(mainViewModel);
        }

    }
}
