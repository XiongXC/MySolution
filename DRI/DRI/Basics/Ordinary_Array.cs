using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DRI.Basics
{
    public class Ordinary_Array
    {
        public static int[,] CreateArray(int m, int n)
        {
            int[,] a = new int[m,n];

            for (int i = 0; i < m; i++)            {
                 
                for (int j = 0; j < n; j++)
                {
                    a[i,j] = i * 13 + j;
                }
            }

            return a;
        }
               

        public static void TestArray(int[,] a)
        {
            //Console.WriteLine(3/2);
            //int[,] a = CreateArray(5, 3);
            int b = a.GetLength(0);
            int c = a.GetLength(1);
            Console.WriteLine("Dimension 0: " + b);
            Console.WriteLine("Dimension 1: " + c);
            Console.WriteLine("");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
