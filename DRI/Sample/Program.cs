using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestArray();
            string s = "08/12/2013";

            Console.WriteLine(Convert.ToDateTime(s));

            Console.ReadKey();
        }

        public static int[,] CreateArray(int m, int n)
        {
            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = i * 13 + j;
                }
            }

            return a;
        }


        public static void TestArray()
        {
            //Console.WriteLine(3/2);
            int[,] a = CreateArray(5, 3);
            int b = a.GetLength(0);
            int c = a.GetLength(1);
            Console.WriteLine("Dimension 0: " + b);
            Console.WriteLine("Dimension 1: " + c);
            Console.WriteLine("");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
