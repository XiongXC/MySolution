using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI;
using DRI.Alg.Tree;

namespace UnitTestDRI.Alg.Tree
{
    [TestClass]
    public class BinaryTreeTest
    {
        BinaryTree<int> BTree;
        
        [TestMethod]
        public void TestMethod1()
        {
            Initialize();

            

        }

        private void Initialize()
        {
            BinaryTree<int> b4 = new BinaryTree<int>(4, null, null);
            BinaryTree<int> b5 = new BinaryTree<int>(5, null, null);
            BinaryTree<int> b6 = new BinaryTree<int>(6, null, null);
            BinaryTree<int> b7 = new BinaryTree<int>(7, null, null);
            BinaryTree<int> b3 = new BinaryTree<int>(3, b6, b7);
            BinaryTree<int> b2 = new BinaryTree<int>(2, b4, b5);
            BinaryTree<int> b1 = new BinaryTree<int>(1, b2, b3);

            this.BTree = b1;
        }
    }
}
