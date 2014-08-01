using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Alg.Sort;
using DRI;

namespace UnitTestDRI.Alg.Sort
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void InsertSort()
        {
            //int length = 50;
            bool sorted = true;
            for (int j = 1; j <6; j++)
            {
                int length = new Random().Next(0, 1000);
                int[] a = MyHelper.CreateArray(length);
                int[] b = new int[length];

                for (int i = 0; i < length; i++)
                {
                    b[i] = a[i];
                }

                Array.Sort(b);

                InsertionSort.Sort(a);

                

                for (int i = 0; i < length; i++)
                {
                    if (b[i] != a[i]) sorted = false;
                }

                Assert.IsTrue(sorted);
            }
        }

        public delegate 


    }
}
