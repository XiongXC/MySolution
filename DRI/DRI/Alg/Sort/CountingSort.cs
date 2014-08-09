using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Sort
{
    public class CountingSort
    { 
        public static void Sort(int[] a)
        {
            if (a.Length <= 1) return;

            int min = a[0];
            int max = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i]) min = a[i];
                if (max < a[i]) max = a[i];
            }

            for(int i=0; i<a.Length;i++)
            {
                a[i] -= min;
            }

            int[] b = new int[max - min+1];

            for(int j=0;j<a.Length;j++)
            {
                b[a[j]]++;
            }

            for (int k = 1; k < b.Length; k++) 
            {
                b[k] += b[k-1];
            }

            int[] c=new int[a.Length];

            for(int k=a.Length-1; k>=0;k--)
            {
               
               c[--b[a[k]]] = a[k]+min;
               
            }           

            Array.Copy(c, a,c.Length);

        }
    }
}
