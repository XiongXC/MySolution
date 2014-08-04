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
            int j = 0;// the last index of sorted group
            for (int i = 1; i < a.Length; i++)
            {
                int k = j;// to track the index to insert

                //if current one is bigger, increase the last indes of the sorted group
                if (a[i] >= a[k])
                {
                    j++;
                }

                //try to find the right place to insert
                else
                {
                    int temp = a[i];

                    while (k >= 0 && a[i] < a[k]) k--;//find it, but point to the place before the right place

                    // shift the sorted group to insert the founded one
                    Shift(a, k + 1, j);
                    a[k + 1] = temp;

                    j++;// increase the last index of the sorted group
                }
            }
        }

        static void Shift(int[] a, int i, int j)
        {
            for (int k = j + 1; k > i; k--)
            {
                a[k] = a[k - 1];
            }
        }
    }
}
