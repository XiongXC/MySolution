using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Int.Arrays;

namespace UnitTestDRI.Int.Arrays
{
    [TestClass]
    public class MaxProductOf3Test
    {
        [TestMethod]
        public void TestMethod_Compute()
        {
            int[] a={1, 3, 5, 2, 8, 0, -1, 3};
            int prodA = 8 * 5 * 3; 

            int[] b= {0, -1, 3, 100, -70, -50};
            int prodB= -70*-50*100;

            Assert.AreEqual(MaxProductOf_3_Elements.Compute(a), prodA);
            Assert.AreEqual(MaxProductOf_3_Elements.Compute(b), prodB);
        }
    }
}
