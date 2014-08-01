using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg.Tree
{
    public class BinaryTree<T>
    {
        T Value;
        BinaryTree<T> LeftTree;
        BinaryTree<T> RightTree;

        public BinaryTree(T Value, BinaryTree<T> LeftTree, BinaryTree<T> RightTree)
        {
            this.Value = Value;
            this.LeftTree = LeftTree;
            this.RightTree = RightTree;
        }

        public void ZTranverse(BinaryTree<T> BTree)
        {
            Queue<T> qi=new Queue<T>();

            

        }

        private Queue<BinaryTree<T>> Tranverse(BinaryTree<T> BTree, int level) 
        {            
            Queue<BinaryTree<T>> qb=new Queue<BinaryTree<T>>();
            if(BTree != null){
                qb.Enqueue(BTree);
                if (level % 2 == 0)
                {
                        

                }
            }

            return qb;
        }
        
    }
}
