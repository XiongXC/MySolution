using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class QuickFindUnionTree
    {
        int[] networks;
       
        public QuickFindUnionTree( int n) {
            networks=new int[n];
            for (int i = 0; i < n; i++) {
                networks[i] = i;
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
           networks[p] = q;
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
