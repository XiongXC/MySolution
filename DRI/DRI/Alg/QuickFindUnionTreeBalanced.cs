using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class QuickFindUnionTreeBalanced
    {
        int[] networks;
        int[] size;
        public QuickFindUnionTreeBalanced( int n) {
            networks=new int[n];
            size = new int[n];
            for (int i = 0; i < n; i++) {
                networks[i] = i;
                size[i] = 1;
            }
        }

        public void Connect(int p,int q) {
            while (q != networks[q])
            {
                q = networks[q];
            }

            while (p != networks[p])
            {
                p = networks[p];
            }
            if (size[p] < size[q])
            {
                networks[p] = q;
                size[q] += size[p];
                size[p] = 1;
            }
            else {
                networks[q] = p;
                size[p] += size[q];
                size[q] = 1;
            }

            
        }

        public bool Find(int p, int q) {
            bool connected = false;
            while(p!= networks[p])
            {
                p= networks[p];
            }

            while(q!= networks[q])
            {
                q= networks[q];
            }

            if (p == q) connected = true;
            return connected;
        }
    }
}
