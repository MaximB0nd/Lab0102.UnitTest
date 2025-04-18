using System;
using NUnit.Framework;
using CheckPassword;

namespace CheckPasswordUnitTest
{
    [TestFixture]
    public class SecurityTests
    {
        private readonly CheckPasswordClass _checker = new CheckPasswordClass();
        
        [Test]
        public void Test1()
        {
            Assert.AreEqual(_checker.IsSafe(""), false);
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(_checker.IsSafe("a"), false);
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual(_checker.IsSafe("Abcdefg1!"), true);
        }
        
        [Test]
        public void Test4()
        {
            Assert.AreEqual(_checker.IsSafe("Abc123"), false);
        }
        
        [Test]
        public void Test5()
        {
            Assert.AreEqual(_checker.IsSafe("Aaaaaaaa1!"), true);
        }

    }
}