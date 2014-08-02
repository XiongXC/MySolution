using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DRI.Alg.Sort;
using DRI;

namespace UnitTestDRI.Alg.Sort
{
    [TestClass]
    public class SortTest
    {
        LinkedList<int[]> arrList;
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            int arrNo=5;

            for (int i = 0; i < arrNo; i++) 
            {
                int arrLength = new Random().Next(0, 100);
                int[] a = MyHelper.CreateArray(arrLength);
                arrList.AddLast(a);
            }          
        }

        [TestMethod]
        public void Sort(Delegate sortMethod)
        {            
            bool sorted = true;
            foreach (int[] a in arrList)
            {               
                int[] b = new int[a.Length];

                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }

                Array.Sort(b);

                InsertionSort.Sort(a);                

                for (int i = 0; i < a.Length; i++)
                {
                    if (b[i] != a[i]) sorted = false;
                }

                Assert.IsTrue(sorted);
            }
        }

        [TestMethod]
        public void InsertSort()
        {
            SortMethod sm=new SortMethod();
            Sort()
        }

        public delegate void SortMethod(int[] a);


    }
}
