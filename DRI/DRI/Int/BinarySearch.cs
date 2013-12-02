using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int
{
    class BinarySearch
    {
        public int Search(int[] a, int key)
        {
            int result = -1;
           
            int start = 0;           
            int end = a.Length-1;
            int m = -1;
            int medium = 0;

            while (end > start)
            {
                m = start + (end - start) / 2;
                medium = a[m];

                if (key == medium) { 
                    result = m; 
                }
                else if (key >medium)
                {
                    start = m + 1;                    
                }
                else
                {
                    end = m - 1;                   
                }                
            }

            return result;
        }
    }
}
