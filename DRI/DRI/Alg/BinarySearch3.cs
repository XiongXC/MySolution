using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    class BinarySearch3
    {
        public int Search(int key, int[] a) 
        {             
            int high=a.Length-1;
            int low=0;

            while (low < high) 
            {
                int middleIndex = low + (high - low) / 2;
                if (key > a[middleIndex]) low = middleIndex + 1;
                else if (key < a[middleIndex]) high = middleIndex - 1;
                else return middleIndex;
            }

            return -1;
        }
    }
}
