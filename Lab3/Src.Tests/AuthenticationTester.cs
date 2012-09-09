using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Src.Controllers;
using Src.Models;

namespace Src.Tests
{
    [TestClass]
    public class AuthenticationTester
    {
        [TestMethod]
        public void IfUserNameIsYngve_ThenLoginIsSuccessful()
        {
            Assert.Inconclusive("Implement me!");
        }

        [TestMethod]
        public void IfIPostValidCredentials_IShouldBeRedirected()
        {
            Assert.Inconclusive("Implement me!");
        }

        [TestMethod]
        public void IfIPostInvalidCredentials_IShouldGoBackToLoginView()
        {
            Assert.Inconclusive("Implement me!");
        }
    }
}
