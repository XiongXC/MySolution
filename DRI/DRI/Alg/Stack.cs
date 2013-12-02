using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class Stack<T>
    {
        T[] arr;
        int size = 20;
        int count;
        public Stack() {
            arr = new T[size];
            count = 0;
        }

        public void Push(T v) {
            if (count == size){
                T[] temp=new T[arr.Length];
                Array.Copy(arr, temp, arr.Length);

                arr=new T[2*arr.Length];
                Array.Copy(temp, arr, temp.Length);
                size = arr.Length;                         
            }

            arr[count++] = v;    
        }

        public T Pop() {
            if (count > 0) {
                return arr[--count];
            }

            throw new Exception();
        }

        public bool IsEmpty() {
            if (count <= 0) return false;
            return true;
        }

        public int Size()
        {
            return count;
        }

        public T Peek()
        {
            return arr[count-1];
        }

    }
}
