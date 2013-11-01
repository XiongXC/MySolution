using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Alg;

namespace UnitTestDRI.Alg
{
    [TestClass]
    public class UnitTest_BinarySearch
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            int[] length = { 0, 1, 2, 23, 68 };
            //int[][] a=new int[length.Length][];
            int key = 547;
            for (int j = 0; j < length.Length; j++)
            {

                int[] a = new int[length[j]];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(0, 1000);
                    Thread.Sleep(100);
                }

                if (a.Length == 0)
                {
                    bool finded = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsFalse(finded);
                }

                int keyIndex = a.Length / 3;
                if (a.Length == 1)
                {
                    bool finded = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsFalse(finded);
                }
                if (a.Length == 1)
                {
                    a[keyIndex] = key;
                    bool finded = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsTrue(finded);
                }

                if (a.Length > 1)
                {
                    a[keyIndex] = key;
                    Array.Sort(a);
                    bool finded = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsTrue(finded);
                }

                if (a.Length > 1)
                {
                    //a[keyIndex] = key;
                    Array.Sort(a);
                    bool finded = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsTrue(finded);
                }
            }

        }
    }
}
