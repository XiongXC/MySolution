using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Sort
{
    public class QuickSort
    {
        public static void Sort(int[] a)
        {
            int p = 0;
            int low =0;
            int high = a.Length - 1;
            QSort(a, p, low, high);
        }

        private static void QSort(int[] a, int p, int low, int high)
        {
            if (low <= high)
            {
                int l = low;
                int middle = Partition(a, p, ref l, high);

                QSort(a, low, low, middle - 1);

                QSort(a, l, l, high);
            }
        }       

        /* 
         * 3-way partition
         * 
        * P: equal group start index 
        */
        private static int Partition(int[] a, int p, ref int l, int high)
        {           
            //int l = low;//unknown left pointer
            int h = high;//unknow right pointer
            while (l <= h)
            {
                if (a[l] < a[p])
                {
                    Swap(a, l, p);
                    l++;
                    p++;
                }

                else if (a[l] > a[p])
                {
                    Swap(a, l, h);                    
                    h--;
                }
                // move unknown pointer to next
                else l++;                
            }

            return p;
        }

        private static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
