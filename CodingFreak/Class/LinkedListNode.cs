using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFreak.Class
{
    public class LinkedList_Node<T>
    {
        public T data;
        public LinkedList_Node<T> next;

        public LinkedList_Node(T val)
        {
            this.data = val;
            this.next = null;
        }
        public LinkedList_Node()
        {

        }
    }
}
