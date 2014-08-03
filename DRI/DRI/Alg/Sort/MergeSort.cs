using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Sort
{
    public class MergeSort
    {
        public static void Sort(int[] a)
        {
            Merge_Sort(a, 0, a.Length - 1);
        }

        private static void Merge_Sort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                Merge_Sort(a, l, m);
                Merge_Sort(a, m + 1, r);

                Merge(a, l, m, r);
            }
        }

        private static void Merge(int[] a, int l, int m, int r)
        {
            int rm = m + 1;
            int left = l;
            int[] merged = new int[r - l + 1];
            for (int i = 0; i < merged.Length; )
            {
                while (l <= m && rm <= r)
                {
                    while (l <= m && a[l] <= a[rm]) merged[i++] = a[l++];
                    while (rm <= r && a[rm] <= a[l]) merged[i++] = a[rm++];
                }

                while (l <= m) merged[i++] = a[l++];
                while (rm <= r) merged[i++] = a[rm++];
            }

            for (int j = 0; j < merged.Length; j++)
            {
                a[left++] = merged[j];
            }

        }
    }
}
