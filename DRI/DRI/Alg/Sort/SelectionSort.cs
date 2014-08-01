using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Sort
{
    public class SelectionSort
    {
        public void Sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min =a[i];
                int k = -1;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (min > a[j]) 
                    { 
                        min = a[j];
                        k = j;
                    }                   
                }

                a[k] = a[i];
                a[i] = min;

            }
        }
    }
}
