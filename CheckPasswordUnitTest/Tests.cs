using System;
using NUnit.Framework;
using CheckPassword;

namespace CheckPasswordUnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string password = "passwordasd";
            Assert.AreEqual(CheckPasswordClass.CheckPassword(password), 1);
        }
    }
}