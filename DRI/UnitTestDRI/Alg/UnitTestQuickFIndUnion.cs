using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Alg;

namespace UnitTestDRI.Alg
{
    [TestClass]
    public class UnitTestQuickFindUnion
    {
        [TestMethod]
        public void Test_QuickFindUnion_Find()
        {
            QuickFindUnion qfu = new QuickFindUnion(10);
            //Assert.IsTrue(true);

            qfu.Connect(3,4);    
            Assert.IsTrue(qfu.Find(4,3));

            qfu.Connect(3, 6);
            Assert.IsTrue(qfu.Find(4, 6));

            Assert.IsFalse(qfu.Find(4, 5));

            qfu.Connect(0, 8);
            Assert.IsTrue(qfu.Find(0, 8));
        }

        [TestMethod]
        public void Test_QuickFindUnionTree_Find()
        {
            QuickFindUnionTree qfu = new QuickFindUnionTree(10);
            //Assert.IsTrue(true);

            qfu.Connect(3, 4);            
            Assert.IsTrue(qfu.Find(4, 3));

            qfu.Connect(3, 6);
            Assert.IsTrue(qfu.Find(4, 6));

            Assert.IsFalse(qfu.Find(4, 5));

            qfu.Connect(0, 8);
            Assert.IsTrue(qfu.Find(0, 8));

            qfu.Connect(0, 4);
            Assert.IsTrue(qfu.Find(3, 8));
        }

        [TestMethod]
        public void Test_QuickFindUnionTreeBalanced_Find()
        {
            QuickFindUnionTreeBalanced qfu = new QuickFindUnionTreeBalanced(10);
            //Assert.IsTrue(true);

            qfu.Connect(3, 4);
            Assert.IsTrue(qfu.Find(4, 3));

            qfu.Connect(3, 6);
            Assert.IsTrue(qfu.Find(4, 6));

            Assert.IsFalse(qfu.Find(4, 5));

            qfu.Connect(0, 8);
            Assert.IsTrue(qfu.Find(0, 8));

            qfu.Connect(0, 4);
            Assert.IsTrue(qfu.Find(3, 8));
        }
    }
}
