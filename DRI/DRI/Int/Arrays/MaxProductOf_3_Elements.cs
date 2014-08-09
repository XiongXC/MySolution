using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int.Arrays
{
    public class MaxProductOf_3_Elements
    {
        public static int Compute(int[] a)
        {
            if (a.Length < 3) throw new Exception("Array cannot have less than 3 elements.");
            
            int product = 0;

            int[] max = Top_N_Element.Find(a, 3, true);
            int[] min = Top_N_Element.Find(a,2,false);

            if (max[0] > 0)
            {

                if (min[0] * min[1] > max[1] * max[2]) product = max[0] * min[0] * min[1];

                else product = max[0] * max[1] * max[2];
            }

            else
            {
                product = max[0] * max[1] * max[2];
            }


            return product;
        }


    }
}
