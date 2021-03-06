﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Src.Business;
using Src.Controllers;

namespace Src.Tests
{
    [TestClass]
    public class ViewTester
    {
        [TestMethod]
        public void ICanNavigateToMyPage()
        {
            UserController homeController = new UserController(new AuthenticationProvider());
            var result = homeController.MyPage() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
