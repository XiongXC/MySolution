using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DRI
{
    public class MyHelper
    {
        public static int[] CreateArray(int n)
        {
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new Random().Next(0, 1000);
                Thread.Sleep(30);
            }

            return a;
        }
    }
}
