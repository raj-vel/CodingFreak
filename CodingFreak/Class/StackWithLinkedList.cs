using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFreak.Class
{
    public class StackWithLinkedList
    {
        LinkedList_Node<int> list = null;

        public void Push(int value)
        {
            if (list == null)
                list = new LinkedList_Node<int>(value);
            else
            {
                var temp = new LinkedList_Node<int>(value);
                temp.next = list;
                list = temp;
            }
        }

        public LinkedList_Node<int> Pop()
        {
            var curr = list;
            if (curr == null)
                return null;
            else
            {
                var next = curr.next;
                list = next;
            }
            return curr;
        }

        public bool IsEmpty()
        {
            return list == null;
        }
    }
}
