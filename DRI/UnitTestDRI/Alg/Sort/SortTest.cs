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

        public delegate void SortDelegate(int[] a);

        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            arrList = new LinkedList<int[]>();

            int arrNo=5;

            for (int i = 0; i < arrNo; i++) 
            {
                int arrLength = new Random().Next(0, 1000);
                int[] a = MyHelper.CreateArray(arrLength);
                arrList.AddLast(a);
            }          
        }
        
        public void Sort(SortDelegate sortMethod)
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

                sortMethod(a);                

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
            SortDelegate sd= InsertionSort.Sort;
            Sort(sd);
        }

        [TestMethod]
        public void SelectSort()
        {
            SortDelegate sd = SelectionSort.Sort;
            Sort(sd);
        }

        [TestMethod]
        public void Quick_Sort()
        {
            SortDelegate sd =QuickSort.Sort;
            Sort(sd);
        }

        [TestMethod]
        public void Merge_Sort()
        {
            SortDelegate sd = MergeSort.Sort;
            Sort(sd);
        }

        [TestMethod]
        public void Counting_Sort()
        {
            SortDelegate sd = CountingSort.Sort;
            Sort(sd);
        }       
    }
}
