using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    class BinarySearch2
    {
        public static bool BinarySearch(int n, int[] a, int startIndex, int endIndex) {
            bool finded = false;
            int midIndex = (endIndex-startIndex+2) / 2-1;

            if (n == a[midIndex]) finded = true;
            if (n > a[midIndex]) finded= BinarySearch(n, a, midIndex + 1, endIndex);
            else finded = BinarySearch(n, a, startIndex, midIndex - 1);
            return finded;
        }       
    }
}
