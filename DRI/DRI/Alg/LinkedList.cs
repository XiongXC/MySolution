using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DRI.Alg
{
    public class Node<T>
    {
        public Node<T> next;
        public T value;
        public Node(T v)
        {
            this.next = null;
            this.value = v;
        }

        public Node()
        {
            this.next = null;
            this.value = default(T);
        }

        /*public bool HasNext()
        {
            if (this.next != null) return true;
            return false;
        }

        public Node<T> Next() {
            return this.next;
        }*/
    }
    public class LinkedList<T>:IEnumerable<T>
    {
        Node<T> head;
        public LinkedList()
        {
            this.head = new Node<T>();
        }

        public void Add(T v)
        {
            Node<T> temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new Node<T>(v);
        }

        public bool Remove(T v)
        {
            //bool removed = false;
            Node<T> current = head.next;
            Node<T> previous = head;
           
            while (current != null && ! current.value.Equals(v)) {
                previous = current;
                current = current.next;
            }

            if (current == null) return false;
            else {
                previous.next = current.next;
                current = null;
                return true;
            }
        }

        public bool Find(T v) {
            Node<T> current = head.next;
            Node<T> previous = head;

            while (current != null && !current.value.Equals(v))
            {
                previous = current;
                current = current.next;
            }

            if (current == null) return false;
            else return true;            
        }

        public IEnumerator<T> GetEnumerator() {
            Node<T> current = head.next;
            while (current != null) {
                yield return current.value;
                current=current.next;
            }
        }

        /*IEnumerator IEnumerable.GetEnumerator { 
            return GetEnumerator;
        }*/
             

    }
}
