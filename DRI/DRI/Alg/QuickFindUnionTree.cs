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
            
           networks[Root(p)] = Root(q);
        }

        public bool Find(int p, int q) {
            bool connected = false;
            if (Root(p) == Root(q)) connected = true;
            return connected;
        }

        private int Root(int p) {            
            while (p != networks[p]) p = networks[p];
            return p;
        }
    
    }
}
