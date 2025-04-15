using System;
using NUnit.Framework;
using CheckPassword;

namespace CheckPasswordUnitTest
{
    [TestFixture]
    public class SecurityTests
    {
        [Test]
        public void Test1()
        {
            string password = "";
            Assert.AreEqual(CheckPasswordClass.CheckPassword(password), 0);
        }
    }
}