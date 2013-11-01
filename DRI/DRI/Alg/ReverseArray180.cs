using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRI.Basics;

namespace DRI.Alg
{
    public class ReverseArray180
    {
        public static int[,] ReverseArray(int[,] a) {
            //int[][] b= new int[a.GetLength(0)][a.GetLength(1)]();
            int half_dimension0=a.GetLength(0)/2;
            int whole_dimension0=a.GetLength(0);
            int half_dimension1=a.GetLength(1)/2;
            int whole_dimension1=a.GetLength(1);
            int temp=0;

            for (int i = 0; i < half_dimension0; i++) {
                for (int j = 0; j < whole_dimension1; j++)
                {
                    temp = a[i,j];
                    a[i,j] = a[whole_dimension0 - i - 1,j];
                    a[whole_dimension0 - i - 1, j]=temp;
                }
            }

            for (int i = 0; i < half_dimension1; i++)
            {
                for (int j = 0; j < whole_dimension0; j++)
                {
                    temp = a[j, i];
                    a[j, i] = a[j,whole_dimension1 - i - 1];
                    a[j,whole_dimension1 - i - 1] = temp;
                }
            } 

            return a;
        }

        public static void TestReverseArray180(){
          int[,] a=  Ordinary_Array.CreateArray(5, 3);
          Ordinary_Array.TestArray(a);
          ReverseArray(a);
          Ordinary_Array.TestArray(a);
        }
    }
}
