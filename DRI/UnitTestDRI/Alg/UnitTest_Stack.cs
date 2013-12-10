using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI;
using DRI.Alg;

namespace UnitTestDRI.Alg
{
    [TestClass]
    public class UnitTest_Stack
    {
        [TestMethod]
        public void TestMethod_Push()
        {
            Stack<int> stack = new Stack<int>();
            int[] a = MyHelper.CreateArray(100);

            for(int i=0;i<a.Length;i++)
            {
                stack.Push(a[i]);
            }

            for(int i= a.Length-1; i>=0; i--)
            {
                Assert.AreEqual(a[i],stack.Pop());
            }
        }
    }
}
