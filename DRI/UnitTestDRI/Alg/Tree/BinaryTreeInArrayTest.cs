using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Alg.Tree;

namespace UnitTestDRI.Alg.Tree
{
    [TestClass]
    public class BinaryTreeInArrayTest
    {
        int[] a;
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            int arrNo = 10;
            a = new int[arrNo];

            for (int i = 0; i < arrNo; i++)
            {
                a[i] = i + 1;
            }
        }

        [TestMethod]
        public void TestMethod_TraverseBreadthFirst()
        {
            int[] b = new int[100];
            BinaryTreeInArray.TranverseTreeBreadthFirst(a, b);
        }

        [TestMethod]
        public void TestMethod_TraverseDepthFirst()
        {
            int[] b = new int[100];
            BinaryTreeInArray.TranverseTreeDepthFirst(a, b);
        }
    }
}
