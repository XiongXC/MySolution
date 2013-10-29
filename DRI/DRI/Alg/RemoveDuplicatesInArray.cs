using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class RemoveDuplicatesInArray
    {
        public static int[] RemoveDuplicates(int[] a) {
           
            int endIndex = 0;
           
            HashSet<int> hash=new HashSet<int>();

            for (int currentIndex = 0; currentIndex < a.Length; currentIndex++) {
                                
                if (hash.Contains(a[currentIndex]) == false) {
                    hash.Add(a[currentIndex]);
                    a[endIndex++] = a[currentIndex];
                }

            }
            int[] b = new int[endIndex];
            for (int k = 0; k < endIndex; k++) {
                b[k] = a[k];
            }
            return b;
        }
    }
}
