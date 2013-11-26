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
    }

    //Implement IEnumerable interface:  only one member public IEnumerator<T> GetEnumerator()
    public class LinkedList<T>:IEnumerable<T>
    {
        public Node<T> head;

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
            return (new LinkedListEnumerator<T>(this));
        }

        //Add this one
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    //Implement IEnumerator Interface:    3 members:    Reset(), Current, MoveNext()
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        public LinkedList<T> linkedList;
        public Node<T> currentNode;

        public T Current
        {
            get
            {
                return currentNode.value;              
            }
        }


        #region IEnumerator Members

        //Sets the enumerator to its initial position, which is before the first element in the collection.” 
        //With a 0 based index, the position just before the first element is -1
        public void Reset() {
            currentNode = linkedList.head;
        }

        //gets the current element in the collection.
        object System.Collections.IEnumerator.Current { get { return Current; } }

        //Advances the enumerator to the next element of the collection.”
        //It is also important to note, that it returns a bool. 
        //“true if the enumerator was successfully advanced to the next element; 
        //false if the enumerator has passed the end of the collection
        public bool MoveNext(){
            if (currentNode.next != null) {
                currentNode = currentNode.next;
                return true; 
            }
            return false;
        }

        public void Dispose()
        {
           
        }

        #endregion  
        
        internal LinkedListEnumerator(LinkedList<T> linkedList) {
            this.linkedList = linkedList;
            this.currentNode = linkedList.head;
            //Reset();
        }
    }


}
