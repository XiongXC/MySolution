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
            q = Root(q);
            p = Root(p);
            if (size[p] < size[q])
            {
                networks[p] = q;
                size[q] += size[p];               
            }
            else {
                networks[q] = p;
                size[p] += size[q];                
            }            
        }

        public bool Find(int p, int q)
        {
            bool connected = false;
            if (Root(p) == Root(q)) connected = true;
            return connected;
        }

        private int Root(int p)
        {
            while (p != networks[p]) p = networks[p];
            return p;
        }
    }
}
