using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class BinarySearch2
    {
        public static bool BinarySearch(int n, int[] a, int startIndex, int endIndex) {

            bool finded = false;
            if (endIndex >= startIndex)
            {
                int midIndex = startIndex + (endIndex - startIndex) / 2;

                if (n == a[midIndex]) return finded = true;
                else if (n > a[midIndex]) return finded = BinarySearch(n, a, midIndex + 1, endIndex);
                else return finded = BinarySearch(n, a, startIndex, midIndex - 1);                 
            }
            else return false;
            
        }       
    }
}
