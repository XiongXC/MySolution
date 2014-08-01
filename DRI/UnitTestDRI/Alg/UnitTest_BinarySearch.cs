using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Alg.Search;

namespace UnitTestDRI.Alg
{
    [TestClass]
    public class UnitTest_BinarySearch
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            int[] length = { 0, 1, 2, 23, 68,101 };
            //int[][] a=new int[length.Length][];
            int key = 547;
            for (int j = 0; j < length.Length; j++)
            {

                int[] a = new int[length[j]];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(0, 1000);
                    if (a[i] == key) a[i]++;
                    Thread.Sleep(10);
                }

                int matchedIndex =-1;

                if (a.Length == 0)
                {
                    matchedIndex = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsFalse(matchedIndex>=0);
                }

                int keyIndex = a.Length / 3;
                int temp = 0;

                if (a.Length == 1)
                {
                    matchedIndex = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsFalse(matchedIndex>=0);
                }
                if (a.Length == 1)
                {
                    a[keyIndex] = key;
                    matchedIndex = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsTrue(matchedIndex>=0);
                }

                if (a.Length > 1)
                {
                    temp = a[keyIndex];
                    a[keyIndex] = key;
                    Array.Sort(a);
                    
                    matchedIndex = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                    Assert.IsTrue(matchedIndex>=0);
                }

                if (a.Length > 1)
                {
                    if (matchedIndex >= 0)
                    {
                        a[matchedIndex] = temp;
                        Array.Sort(a);
                        matchedIndex = BinarySearch2.BinarySearch(key, a, 0, a.Length - 1);
                        Assert.IsFalse(matchedIndex>=0);
                    }
                }
            }
        }

        [TestMethod]
        public void Test_binarySearch()
        {
            int[] length = { 0, 1, 2, 23, 68, 101 };
            //int[][] a=new int[length.Length][];
            int key = 547;
            for (int j = 0; j < length.Length; j++)
            {

                int[] a = new int[length[j]];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Random().Next(0, 1000);
                    if (a[i] == key) a[i]++;
                    Thread.Sleep(10);
                }

                int matchedIndex = -1;

                if (a.Length == 0)
                {
                    matchedIndex = BinarySearch.binarySearch(a, key);
                    Assert.IsFalse(matchedIndex >= 0);
                }

                int keyIndex = a.Length / 3;
                int temp = 0;

                if (a.Length == 1)
                {
                    matchedIndex = BinarySearch.binarySearch(a,key);
                    Assert.IsFalse(matchedIndex >= 0);
                }
                if (a.Length == 1)
                {
                    a[keyIndex] = key;
                    matchedIndex = BinarySearch.binarySearch(a,key);
                    Assert.IsTrue(matchedIndex >= 0);
                }

                if (a.Length > 1)
                {
                    temp = a[keyIndex];
                    a[keyIndex] = key;
                    Array.Sort(a);

                    matchedIndex = BinarySearch.binarySearch(a, key);
                    Assert.IsTrue(matchedIndex >= 0);
                }

                if (a.Length > 1)
                {
                    if (matchedIndex >= 0)
                    {
                        a[matchedIndex] = temp;
                        Array.Sort(a);
                        matchedIndex = BinarySearch.binarySearch(a,key);
                        Assert.IsFalse(matchedIndex >= 0);
                    }
                }
            }
        }


    }
}
