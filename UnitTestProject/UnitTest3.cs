using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TravelAgency;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void AuthTestSuccess()
        {
            var page = new LoginPage(null);
            Assert.IsTrue(page.Auth("thd", "123456"));
            Assert.IsTrue(page.Auth("sqeaz", "qwert23"));
            Assert.IsTrue(page.Auth("Admin", "qwerty1"));
        }
    }
}
