using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Alg
{
    public class Queue<T>
    {
        int size = 20;
        int count;
        T[] arr;

        public Queue()
        {
            arr = new T[size];
            count = 0;
        }

        public bool Enqueue(T v)
        {
            if (count == size)
            {
                T[] temp = new T[arr.Length];
                Array.Copy(arr, temp, arr.Length);

                arr = new T[2 * arr.Length];
                Array.Copy(temp, arr, temp.Length);
                size = arr.Length;
            }

            arr[count++] = v;
            return true;
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T temp = arr[0];
                for (int i = 0; i < count; )
                {
                    arr[i] = arr[++i];
                }
                count--;
                return temp;
            }

            else
            {
                throw new Exception("Empty Queue");
            }
        }

        public bool IsEmpty()
        {
            if (count == 0) return false;
            return true;
        }

        public int Size()
        {
            return count;
        }
    }
}
