using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Src.Business;
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
            IAuthenticationProvider provider = new AuthenticationProvider();
            Assert.IsTrue(provider.Validate("yngve", "blabla"));
        }



        [TestMethod]
        public void IfIPostValidCredentials_IShouldBeRedirected()
        {
            string username = "yngve";
            string password = "aldkjflask";
            var authProvider = new Mock<IAuthenticationProvider>();
            authProvider.Setup(c => c.Validate(username, password))
                .Returns(true);
            
            UserController uc = new UserController(authProvider.Object);

            var result =
                uc.Login(new LoginViewModel() {Username = username, Password = password}, "some/url") as RedirectResult;
            
            Assert.IsNotNull(result);
            Assert.AreEqual("some/url", result.Url);
        }

        [TestMethod]
        public void IfIPostInvalidCredentials_IShouldGoBackToLoginView()
        {
            string username = "yngvebn";
            string password = "aldkjflask";
            var authProvider = new Mock<IAuthenticationProvider>();
            authProvider.Setup(c => c.Validate(username, password))
                .Returns(false);
            
            UserController uc = new UserController(authProvider.Object);

            var result =
                uc.Login(new LoginViewModel() { Username = username, Password = password }, "some/url") as ViewResult;
            
            Assert.IsNotNull(result);
            Assert.IsFalse(result.ViewData.ModelState.IsValid);
        }
    }
}
