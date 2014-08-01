using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Search
{
    public class BinarySearch2
    {
        public static int BinarySearch(int n, int[] a, int startIndex, int endIndex) {

            
            if (endIndex >= startIndex)
            {
                int midIndex = startIndex + (endIndex - startIndex) / 2;

                if (n == a[midIndex]) return midIndex;
                else if (n > a[midIndex]) return  BinarySearch(n, a, midIndex + 1, endIndex);
                else return BinarySearch(n, a, startIndex, midIndex - 1);                 
            }
            else return -1;
            
        }       
    }
}
