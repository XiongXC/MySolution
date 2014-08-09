using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int
{
    public class MaxProductOfN_In_M_Bits
    {
        public static bool HasMaxProduct(int bits, int no, int[] range) {
            bool hasMaxNo = false;

            int maxNo = 0;
            int remainder = 9;
            for (int i = 1; i <= bits; i++) {
                maxNo = maxNo * 10+remainder;                
            }

            Array.Sort(range);
            int leastProd = range[0];
            for (int i = 1; i < no; i++) {
                leastProd *= range[i];
            }

            if (leastProd <= maxNo) hasMaxNo = true;

            return hasMaxNo;
        }

        public static bool Available_MaxProduct(int bits, int no, int[] range)
        {
            bool hasMaxNo = false;

            int maxNo = 0;
            int remainder = 9;
            for (int i = 1; i <= bits; i++)
            {
                maxNo = maxNo * 10 + remainder;
            }

            Array.Sort(range);

            int maxProd = range[range.Length/2];
            for (int i = 1; i < no; i++)
            {
                maxProd *= range[i];
            }

            if (maxProd <= maxNo) hasMaxNo = true;

            return hasMaxNo;
        } 
    }
}
