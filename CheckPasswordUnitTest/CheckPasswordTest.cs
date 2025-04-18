using System;
using NUnit.Framework;
using CheckPassword;

namespace CheckPasswordUnitTest
{
    [TestFixture]
    public class CheckPasswordTest
    { 
        private readonly CheckPasswordClass _checker = new CheckPasswordClass();
        
        [Test]
        public void Test1()
        {
            Assert.AreEqual(_checker.CheckPassword(""), 0);
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(_checker.CheckPassword("a"), 1);
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual(_checker.CheckPassword("abcdefgh"), 2);
        }
        
        [Test]
        public void Test4()
        {
            Assert.AreEqual(_checker.CheckPassword("Abcdefgh"), 3);
        }
        
        [Test]
        public void Test5()
        {
            Assert.AreEqual(_checker.CheckPassword("Abcdefg1"), 4);
        }
        
        [Test]
        public void Test6()
        {
            Assert.AreEqual(_checker.CheckPassword("Abcdefg1!"), 5);
        }
        
        [Test]
        public void Test7()
        {
            Assert.AreEqual(_checker.CheckPassword("12345678"), 2);
        }
        
        [Test]
        public void Test8()
        {
            Assert.AreEqual(_checker.CheckPassword("!@#$%^&*"), 2);
        }
        
        [Test]
        public void Test9()
        {
            Assert.AreEqual(_checker.CheckPassword("Aaaaaaaa1!"), 5);
        }
    }
}