﻿using System;
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
    }
}
