using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Sort
{
    public class InsertionSort
    {
        public static void Sort(int[] a) 
        {
            int j = 0;
            for (int i = 1; i < a.Length; i++) 
            {
                int k = j;
                int temp=a[i];
                while (k >= 0 && a[i] < a[k]) k--;
                if (k != j)
                {
                    Shift(a, k+1, j);
                    a[k + 1] = temp;
                }

                j++;
            }
        }

        static void Shift(int[] a, int i, int j) 
        {
            for (int k =j+1; k >i; k--) 
            {
                a[k] = a[k - 1];
            }
        }
    }
}
