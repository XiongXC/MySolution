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

        public static void ZTranverse(BinaryTree<T> BTree)
        {

            Stack<BinaryTree<T>> BTreeStack = new Stack<BinaryTree<T>>();

            Queue<BinaryTree<T>> BTreeQueue = new Queue<BinaryTree<T>>();


            BTreeStack.Push(BTree);

            BTreeQueue.Enqueue(BTree);

            bool leftFirst=true;

            BTreeStack=Tranverse(BTreeStack,BTreeQueue,ref leftFirst);
            while (!BTreeStack.IsEmpty()) 
            {
                BTreeStack = Tranverse(BTreeStack, BTreeQueue, ref leftFirst);
            }

        }

        private static Stack<BinaryTree<T>> Tranverse(Stack<BinaryTree<T>> BTreeStack, Queue<BinaryTree<T>> BTreeQueue, ref bool leftFirst) 
        {            
            Stack<BinaryTree<T>> tempStack = new Stack<BinaryTree<T>>();           

            while (!BTreeStack.IsEmpty()) 
            {
                BinaryTree<T> bTree = BTreeStack.Pop();
                
                if (leftFirst == true)
                {
                    if (bTree.LeftTree != null) { tempStack.Push(bTree.LeftTree); BTreeQueue.Enqueue(bTree.LeftTree); }
                    if (bTree.RightTree != null) { tempStack.Push(bTree.RightTree); BTreeQueue.Enqueue(bTree.RightTree); }
                }
                else 
                {
                    if (bTree.RightTree != null) { tempStack.Push(bTree.RightTree); BTreeQueue.Enqueue(bTree.RightTree); }   
                    if (bTree.LeftTree != null) { tempStack.Push(bTree.LeftTree); BTreeQueue.Enqueue(bTree.LeftTree); }                                     
                }
            }

            leftFirst = !leftFirst;

            BTreeStack = tempStack;

            return BTreeStack;
        }
        
    }
}
