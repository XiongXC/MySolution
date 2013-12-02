using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI;
using DRI.Alg;

namespace UnitTestDRI
{
    [TestClass]
    public class Queue
    {
        [TestMethod]
        public void TestMethod1()
        {
            Queue<int> queue = new Queue<int>();
            int[] a = MyHelper.CreateArray(100);

            for (int i = 0; i < a.Length; i++)
            {
                queue.Enqueue(a[i]);
            }

            for (int i = 0; i <a.Length; i++)
            {
                Assert.AreEqual(a[i], queue.Dequeue());
            }
           
        }
    }
}
