using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int.Search
{
    class FirstItemLargerThanKeyInSortedArray
    {
        public int Search(int[] a, int key)
        {
            int i = BinarySearch.Search(a, key);
            if (i >= 0)
            {
                int k = i + 1;
                while (k < a.Length && a[k] == a[i]) { k++; }
                if (k == a.Length) return -1;
                else return k; 
            }
            return i;
        }
    }
}
