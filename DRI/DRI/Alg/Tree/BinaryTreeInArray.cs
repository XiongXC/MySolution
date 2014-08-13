using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Tree
{
    public class BinaryTreeInArray
    {
        public static int Sum(int[] a)
        {
            int sum = 0;



            return sum;
        }

        public static void TranverseTreeBreadthFirst(int[] a, int[] b)
        {
            Queue<int> q = new Queue<int>();
           
            int j=-1;
            q.Enqueue(0);

            //breadfirst tranverse
            while (!q.IsEmpty())
            {
                int k=q.Dequeue();

                b[++j] = a[k];

                if ((k + 2) < a.Length) q.Enqueue(k + 2);
                if ((k + 3) < a.Length) q.Enqueue(k + 3);
            }            
        }

        public static void TranverseTreeDepthFirst(int[] a, int[] b)
        {
            Stack<int> st = new Stack<int>();
            int i = 0;
            int j = -1;
            st.Push(i);

            //DepthFirst tranverse
            while (!st.IsEmpty())
            {
                int k = st.Pop();

                b[++j] = a[k];

                if ((k + 3) < a.Length) st.Push(k + 3);
                if ((k + 2) < a.Length) st.Push(k + 2);                
            }
        }
    }
}
