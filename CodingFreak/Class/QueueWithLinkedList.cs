using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFreak.Class
{
    public class QueueWithLinkedList
    {
        LinkedList_Node<int> front = null, rear = null;

        public void Enqueue(int value)
        {
            LinkedList_Node<int> node = new LinkedList_Node<int>(value);
            if (front == null)
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
            }
        }

        public LinkedList_Node<int> Dequeue()
        {
            if (front == null)
                return null;

            LinkedList_Node<int> temp = front;
            front = front.next;

            if (front == null)
                rear = null;

            return temp;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public LinkedList_Node<int> Peek()
        {
            if (front == null)
                return null;

            return front;
        }
    }
}
