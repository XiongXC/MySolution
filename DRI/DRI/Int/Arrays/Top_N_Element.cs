using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int.Arrays
{
    class Top_N_Element
    {
        public static int[] Find(int[] a, int k, bool isMax)
        {
            int[] result = new int[k];

            for (int i = 0; i < k; i++)
            {
                int maxIndex = i;
                int tempMax = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (isMax == true)
                    {
                        if (tempMax < a[j]) 
                        { 
                            maxIndex = j;
                            tempMax = a[j];
                        }
                    }
                    else
                    {
                        if (tempMax > a[j])
                        {
                            maxIndex = j;
                            tempMax = a[j];
                        }
                    }
                }

                a[maxIndex] = a[i];                
                a[i] = tempMax;                
            }

            for (int m = 0; m < k; m++)
            {
                result[m] = a[m];
            }

            return result;
        }
    }
}
