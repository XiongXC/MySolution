using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Basics
{
    public class JaggedArray
    {
        public static int[][] createArray(int m, int n){
            int[][] a=new int[m][];

            for (int i = 0; i < m; i++) {
                a[i] = new int[n];
                for(int j=0;j<n;j++){
                    a[i][j]=i*13+j;
                }
            }

            return a;
        }

        public static void TestJaggedArray()
        {
            //Console.WriteLine(3/2);
            int[][] a = JaggedArray.createArray(5, 3);
            int b = a.GetLength(0);
            //int c = a.GetLength(1);
            Console.WriteLine("Dimension 0: " + a.GetLength(0));
            //Console.WriteLine("Dimension 1: " + a.GetLength(1));
            Console.WriteLine("");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    Console.Write(a[i][j] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
