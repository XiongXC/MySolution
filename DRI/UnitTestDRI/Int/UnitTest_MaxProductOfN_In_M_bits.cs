using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRI.Int;

namespace UnitTestDRI.Int
{
    [TestClass]
    public class UnitTest_MaxProductOfN_In_M_bits
    {
        [TestMethod]
        public void TestHasMaxNo()
        {
            int n = 1;
            int o = 2;
            int[] range = {3,4,4,5,6,7,8,9 };
            Assert.IsFalse(MaxProductOfN_In_M_Bits.HasMaxProduct(n,o,range));

            n = 2;
            o = 2;
            Assert.IsTrue(MaxProductOfN_In_M_Bits.HasMaxProduct(n, o, range));
            
            n = 2;
            o = 3;
            Assert.IsTrue(MaxProductOfN_In_M_Bits.HasMaxProduct(n, o, range));

            n = 4;
            o = 5;
            Assert.IsTrue(MaxProductOfN_In_M_Bits.HasMaxProduct(n, o, range));



        }
    }
}
