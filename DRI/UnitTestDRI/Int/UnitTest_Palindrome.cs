using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Int;

namespace UnitTestDRI.Int
{
    [TestClass]
    public class UnitTest_Palindrome
    {
        [TestMethod]
        public void TestIsPalindromWithSpaceAgnostic()
        {
            Palindrome p = new Palindrome();
            string s = "abba";
            Assert.IsTrue(p.IsPalindromWithSpaceAgnostic(s));
            string s1 = "ababa";
            Assert.IsTrue(p.IsPalindromWithSpaceAgnostic(s1));
            string s2 = "ab ba";
            Assert.IsTrue(p.IsPalindromWithSpaceAgnostic(s2));
            string s3 = "ab b a";
            Assert.IsTrue(p.IsPalindromWithSpaceAgnostic(s3));
            string s4 = "a";
            Assert.IsTrue(p.IsPalindromWithSpaceAgnostic(s4));
            string s5 = "   a a  ba     a a ";
            Assert.IsFalse(p.IsPalindromWithSpaceAgnostic(s5));
        }
    }
}
