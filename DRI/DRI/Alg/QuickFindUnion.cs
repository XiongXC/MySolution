using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class QuickFindUnion
    {
        int[] networks;
       
        public QuickFindUnion( int n) {
            networks=new int[n];
            for (int i = 0; i < n; i++) {
                networks[i] = i;
            }
        }

        public void Connect(int p,int q) {
            int temp = networks[p];
            for (int i = 0; i < networks.Length; i++)
            {                
                if(networks[i]==temp)
                networks[i] = networks[q];
            }
        }

        public bool Find(int p, int q) {
            bool connected = false;
            if (networks[p] == networks[q]) connected = true;
            return connected;
        }
    }
}
