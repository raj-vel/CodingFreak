using CodingFreak.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingFreak
{
    public partial class LinkedList : Form
    {
        public LinkedList()
        {
            InitializeComponent();
        }

        private void PrintNode(LinkedList_Node<int> node)
        {
            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        private void Add_Node_At_Front_Click(object sender, EventArgs e)
        {
            //var front = AddNodeAtFront(null, new int[] { 1, 2, 3, 4, 5 });
            //PrintNode(front);

            var back = AddNodeAtLast(null, new int[] { 1, 2, 3, 4, 5 });
            PrintNode(back);
        }

        private LinkedList_Node<int> AddNodeAtFront(LinkedList_Node<int> node, int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                var temp = new LinkedList_Node<int>(arr[i]);
                temp.next = node;
                node = temp;
            }

            return node;
        }

        private LinkedList_Node<int> AddNodeAtLast(LinkedList_Node<int> node, int[] arr)
        {
            if(node == null)
            {
                node = new LinkedList_Node<int>();
            }
            LinkedList_Node<int> retNode = node;
            for(int i = 0; i< arr.Length; i++)
            {
                node.data = arr[i];
                if(i != arr.Length - 1)
                {
                    node.next = new LinkedList_Node<int>();
                }
                else
                {
                    node.next = null;
                }
                node = node.next;
            }

            return retNode;
        }

        private void Insert_Node_At_Correct_Position_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 3, 4, 5, 6, 7 });
            var list1_Res = InsertAtCorrectPosition(list1, 1);
            PrintNode(list1_Res);
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");

            var list2 = AddNodeAtLast(null, new int[] { 1, 2, 7, 8, 9 });
            var list2_Res = InsertAtCorrectPosition(list2, 4);
            PrintNode(list2_Res);

            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");

            var list3 = AddNodeAtLast(null, new int[] { 1, 2, 3, 4, 5 });
            var list3_Res = InsertAtCorrectPosition(list3, 9);
            PrintNode(list3_Res);

        }

        private LinkedList_Node<int> InsertAtCorrectPosition(LinkedList_Node<int> head, int val)
        {
            if (head == null)
                return new LinkedList_Node<int>(val);

            // Inserting node at header
            if(head.data >= val)
            {
                var temp = new LinkedList_Node<int>(val);
                temp.next = head;
                return temp;
            }

            // Inserting at Middle or Last
            var retNode = head;
            while(head != null && head.next != null && head.next.data < val )
            {
                head = head.next;
            }

            var next = head.next;
            var newNode = new LinkedList_Node<int>(val);
            head.next = newNode;
            newNode.next = next;

            return retNode;
        }

        private void MergeSort_LinkedLists_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 9, 3, 4, 2, 5, 1 });
            Console.WriteLine("Before Sorting:");
            PrintNode(list1);
            var result = DivideList(list1);
            Console.WriteLine("After Sorting:");
            PrintNode(result);
        }

        private LinkedList_Node<int> DivideList(LinkedList_Node<int> node)
        {
            LinkedList_Node<int> oldHead = node;
            int mid = GetLength(node) / 2;
            if (node.next == null)
                return node;


            while (mid -1 > 0)
            {
                oldHead = oldHead.next;
                mid--;
            }
            LinkedList_Node<int> newHead = oldHead.next;
            oldHead.next = null;
            oldHead = node; // make one pointer points at the beginning of the first half of the list

            LinkedList_Node<int> t1 = DivideList(oldHead);
            LinkedList_Node<int> t2 = DivideList(newHead);

            return MergeList(t1, t2);
        }

        private LinkedList_Node<int> MergeList(LinkedList_Node<int> t1, LinkedList_Node<int> t2)
        {
            if (t1 == null)
                return t2;

            if (t2 == null)
                return t1;

            LinkedList_Node<int> t = null;
            if(t1.data < t2.data)
            {
                t = t1;
                t.next = MergeList(t1.next, t2);
            }
            else
            {
                t = t2;
                t.next = MergeList(t1, t2.next);
            }

            return t;
        }

        private int GetLength(LinkedList_Node<int> node)
        {
            int count = 0;
            LinkedList_Node<int> temp = node;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }

        private void Remove_Duplicates_On_Sorted_Nodes_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 1, 2,2,2,2,3,4,4,5 });
            Console.WriteLine("Before Removing Duplicates:");
            PrintNode(list1);
            var result = RemoveDuplicatesOnSortedNodes(list1);
            Console.WriteLine("After Removing Duplicates:");
            PrintNode(result);
        }

        private LinkedList_Node<int> RemoveDuplicatesOnSortedNodes(LinkedList_Node<int> node)
        {
            LinkedList_Node<int> retNode = node;

            if (node == null || node.next == null)
                return node;

            while(node != null && node.next != null)
            {
                if(node.data == node.next.data)
                {
                    var nextNext = node.next.next;
                    node.next = nextNext;
                }
                else
                {
                    node = node.next;
                }
            }

            return retNode;
        }

        private void Move_FrontNode_Of_List_To_AnotherList_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 1, 2, 3 });
            var list2 = AddNodeAtLast(null, new int[] { 6, 4, 2 });
            MoveFrontNodeOfListToAnotherList(list1, list2);
        }

        private void MoveFrontNodeOfListToAnotherList(LinkedList_Node<int> list1, LinkedList_Node<int> list2)
        {
            if (list1 == null || list2 == null)
                Console.WriteLine("Invalid Input");

            Console.WriteLine("Before ListNode1 - ");
            PrintNode(list1);
            Console.WriteLine("Before ListNode2 - ");
            PrintNode(list2);

            LinkedList_Node<int> retSecondNode = list2.next;
            list2.next = null;
            list2.next = list1;
            list1 = list2;
            list2 = retSecondNode;

            Console.WriteLine("After ListNode1 - ");
            PrintNode(list1);
            Console.WriteLine("After ListNode2 - ");
            PrintNode(list2);
        }

        private void Move_Even_Nodes_To_End_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine("Before reversing even nodes:");
            PrintNode(list1);
            var result = MoveEvenNodesToEndOfList(list1);
            Console.WriteLine("After reversing even nodes:");
            PrintNode(result);
        }

        private LinkedList_Node<int> MoveEvenNodesToEndOfList(LinkedList_Node<int> node)
        {
            LinkedList_Node<int> oddNode = node;
            LinkedList_Node<int> evenNode = null, prev = null;

            while(oddNode != null && oddNode.next != null)
            {
                if(oddNode.next !=null)
                {
                    var newNode = oddNode.next;
                    oddNode.next = oddNode.next.next;

                    newNode.next = evenNode;
                    evenNode = newNode;
                }

                prev = oddNode;
                oddNode = oddNode.next;
            }

            if (oddNode != null)
                oddNode.next = evenNode;
            else
                prev.next = evenNode;

            return node;
        }

        private void Merge_TwoLists_In_Alternate_Order_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 1, 2, 3 });
            var list2 = AddNodeAtLast(null, new int[] { 4, 5, 6 });
            var res = MergeAlternateNodes(list1, list2);
            PrintNode(res);
        }

        private LinkedList_Node<int> MergeAlternateNodes(LinkedList_Node<int> list1, LinkedList_Node<int> list2)
        {
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            var list1_temp = list1;
            var list2_temp = list2;

            var retNode = list1_temp;

            while(list1 !=null && list2 != null)
            {
                list1_temp = list1.next;
                list2_temp = list2.next;

                
                list1.next = list2;
                list1.next.next = list1_temp;

                list1 = list1.next.next;
                list2 = list2_temp;
            }

            return retNode;
        }

        private void Merge_Two_Sorted_Lists_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 1, 2, 3, 5, 11, 12, 13, 14, 15 });
            var list2 = AddNodeAtLast(null, new int[] { 2, 4, 6, 7, 9 });
            var res = MergeTwoSortedLists(list1, list2);
            PrintNode(res);
        }

        private LinkedList_Node<int> MergeTwoSortedLists(LinkedList_Node<int> list1, LinkedList_Node<int> list2)
        {
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            LinkedList_Node<int> retNode = null;
            if(list1.data < list2.data)
            {
                retNode = list1;
                list1 = list1.next;
            }
            else
            {
                retNode = list2;
                list2 = list2.next;
            }
            var result = retNode;

            while (list1 != null && list2 != null)
            {
                if(list1.data < list2.data)
                {
                    retNode.next = list1;
                    list1 = list1.next;
                    retNode = retNode.next;
                }
                else
                {
                    retNode.next = list2;
                    list2 = list2.next;
                    retNode = retNode.next;
                }
            }

            if(list1 != null)
            {
                retNode.next = list1;
            }

            if (list2 != null)
                retNode.next = list2;


            return result;
        }

        private void Intersection_Of_Two_Sorted_LinkedLists_Click(object sender, EventArgs e)
        {
            var list1 = AddNodeAtLast(null, new int[] { 1, 4, 7, 12 });
            var list2 = AddNodeAtLast(null, new int[] { 2, 4, 6, 8, 9, 10, 11, 12, 13 });
            var res = IntersectionOfTwoSortedLists(list1, list2);
            PrintNode(res);
        }

        private LinkedList_Node<int> IntersectionOfTwoSortedLists(LinkedList_Node<int> list1, LinkedList_Node<int> list2)
        {
            if (list1 == null || list2 == null)
                return null;

            LinkedList_Node<int> head = null, tail = null;

            while(list1 != null && list2 != null)
            {
                if(list1.data == list2.data)
                {
                    if(head == null)
                    {
                        tail = head = new LinkedList_Node<int>(list1.data);
                    }
                    else
                    {
                        tail = tail.next = new LinkedList_Node<int>(list1.data);
                    }

                    list1 = list1.next;
                    list2 = list2.next;
                }
                else if(list1.data < list2.data)
                {
                    list1 = list1.next;
                }
                else
                {
                    list2 = list2.next;
                }
            }

            return head;
        }

        private void Reverse_LinkedList_Iterative_Click(object sender, EventArgs e)
        {
            var list = AddNodeAtLast(null, new int[] { 2, 4, 6, 8, 9, 10, 11, 12, 13 });
            Console.WriteLine("Before Reverse: ");
            PrintNode(list);
            var res = ReverseLinkedList_Iterative(list);
            Console.WriteLine("After Reverse: ");
            PrintNode(res);
        }

        private LinkedList_Node<int> ReverseLinkedList_Iterative(LinkedList_Node<int> head)
        {
            if (head == null || head.next == null)
                return head;

            LinkedList_Node<int> prev = null;
            LinkedList_Node<int> current = head;

            while (current != null)
            {
                LinkedList_Node<int> next = current.next;

                current.next = prev;

                prev = current;
                current = next;
            }

            return prev;
        }

        private void Reverse_Linkedlist_Recursive_Click(object sender, EventArgs e)
        {
            var list = AddNodeAtLast(null, new int[] { 2, 4, 6, 8, 9, 10, 11, 12, 13 });
            Console.WriteLine("Before Reverse: ");
            PrintNode(list);
            var res = ReverseLinkedList_Recursive(list, null, list);
            Console.WriteLine("After Reverse: ");
            PrintNode(res);
        }

        private LinkedList_Node<int> ReverseLinkedList_Recursive(LinkedList_Node<int> curr, LinkedList_Node<int> prev, LinkedList_Node<int> head)
        {
            if(curr == null)
            {
                head = prev;
                return head;
            }

            head = ReverseLinkedList_Recursive(curr.next, curr, head);
            curr.next = prev;

            return head;
        }

        private void Stack_Implementation_Of_Linkedlist_Click(object sender, EventArgs e)
        {
            StackWithLinkedList list = new StackWithLinkedList();
            Console.WriteLine("Checking Is Empty - " + list.IsEmpty());
            Console.WriteLine("Push 5 - "); list.Push(5);
            Console.WriteLine("Push 4 - "); list.Push(4);
            Console.WriteLine("Push 3 - "); list.Push(3);

            Console.WriteLine("Pop 3 - " + list.Pop().data);
            Console.WriteLine("Pop 4 - " + list.Pop().data);
            Console.WriteLine("Checking Is Empty - " + list.IsEmpty());
            Console.WriteLine("Pop 5 - " + list.Pop().data);

            Console.WriteLine("Checking Is Empty - " + list.IsEmpty());
        }

        private void Queue_Implementation_Using_Linkedlist_Click(object sender, EventArgs e)
        {
            QueueWithLinkedList list = new QueueWithLinkedList();
            Console.WriteLine("Checking Is Empty - " + list.IsEmpty());
            Console.WriteLine("Push 5 - "); list.Enqueue(5);
            Console.WriteLine("Push 4 - "); list.Enqueue(4);
            Console.WriteLine("Push 3 - "); list.Enqueue(3);

            Console.WriteLine("Pop 5 - " + list.Dequeue().data);
            Console.WriteLine("Peek 4 - " + list.Peek().data);
            Console.WriteLine("Pop 4 - " + list.Dequeue().data);
            Console.WriteLine("Checking Is Empty - " + list.IsEmpty());
            Console.WriteLine("Pop 3 - " + list.Dequeue().data);

            Console.WriteLine("Checking Is Empty - " + list.IsEmpty());
        }
    }
}









