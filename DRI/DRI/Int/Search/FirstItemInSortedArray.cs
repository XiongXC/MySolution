using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int.Search
{
    class FirstItemInSortedArray
    {
        public int Search(int[] a, int key) {
            
            //Use binary Search
            int i = BinarySearch.Search(a, key);
            int l = 0;

            if (i >= 0)
            { 
                int k=i-1;
                while (k>=0 && a[i] == a[k]) { k--;}
                return k++;
            }

            return i;
        }
    }
}
