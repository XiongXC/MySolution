using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Alg;
using DRI;
using System.Collections;

namespace UnitTestDRI.Alg
{
    [TestClass]
    public class UnitTest_LinkedList
    {
        int[] a;
        LinkedList<int> int_list;
        public UnitTest_LinkedList()
        {
            a = MyHelper.CreateArray(30);
            int_list=new LinkedList<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int_list.Add(a[i]);
            }
        }

        /*[TestMethod]
        public void Test_Add()
        {
            int[] b =new int[a.Length];
            int j=0;
            Node<int> iterator= int_list.GetIterator();

            while(iterator.HasNext()==true){
                iterator=iterator.Next();
                b[j++] = iterator.value;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }*/


        [TestMethod]
        public void Test_Add()
        {
            int[] b = new int[a.Length];
            int j = 0;
            IEnumerator iterator = int_list.GetEnumerator();

            while (iterator.MoveNext() == true)
            {
                 
                b[j++] = (int)iterator.Current;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(a[i], b[i]);
            }
        }

        [TestMethod]
        public void Test_Add1()
        {
            int[] b = new int[a.Length];
            int j = 0;
            
            foreach (int k in int_list)
            {
                Assert.AreEqual(a[j++], k);
            }
             
        }

        [TestMethod]
        public void Test_Remove()
        { 
            LinkedList<int> list=new LinkedList<int>();
            Assert.IsFalse(list.Remove(5));

            list = int_list;
            Assert.IsTrue(list.Remove(a[5]));

        }

        [TestMethod]
        public void Test_Find()
        {
            LinkedList<int> list = new LinkedList<int>();
            Assert.IsFalse(list.Find(5));

            list = int_list;
            Assert.IsTrue(list.Find(a[5]));

        }
    }
}
