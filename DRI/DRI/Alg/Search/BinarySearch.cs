﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Search
{
    public class BinarySearch
    {
        public static int binarySearch(int[] a, int key)
        {
            int low = 0;
            int high = a.Length - 1;

            while (low <= high)
            {
                //don't use (low+high)/2, it may cause overflow.
                int mid =low + (high-low) / 2;
                int midVal = a[mid];

                if (midVal < key)
                    low = mid + 1;
                else if (midVal > key)
                    high = mid - 1;
                else
                    return mid; // key found
            }
            return -(low + 1);  // key not found.
        }
    }
}
