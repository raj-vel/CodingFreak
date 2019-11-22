using CodingFreak.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodingFreak
{
    public partial class BinaryTree : Form
    {
        public BinaryTree()
        {
            InitializeComponent();
        }

        private BTNode ConstructTreeforIsSymmetic_1()
        {
            BTNode node;
            node = new BTNode(1);
            node.left = new BTNode(2);
            node.left.left = new BTNode(3);
            node.left.right = new BTNode(4);
            node.right = new BTNode(2);
            node.right.left = new BTNode(4);
            node.right.right = new BTNode(3);
            return node;
        }

        private void Check_If_Two_BinaryTree_Are_Identical_Click(object sender, EventArgs e)
        {
            var node1 = ConstructTreeforIsSymmetic_1();
            var node2 = ConstructTreeforIsSymmetic_1();
            Console.WriteLine("Is Both BinaryTrees are Identical - " + CheckIfTwoBinaryTreeAreIdentical_Recursive(node1, node2));
        }

        private bool CheckIfTwoBinaryTreeAreIdentical_Recursive(BTNode node1, BTNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if(node1 != null && node2 != null && node1.data == node2.data)
            {
                return CheckIfTwoBinaryTreeAreIdentical_Recursive(node1.left, node2.left)
                    && CheckIfTwoBinaryTreeAreIdentical_Recursive(node1.right, node2.right);
            }

            return false;
        }

        private void Height_Of_BinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            Console.WriteLine("Height of Binary Tree is - " + HeightOfBinaryTree(node));
        }

        private BTNode ConstructTreeforBST()
        {
            // BST Image is here
            // https://www.programcreek.com/2014/04/leetcode-binary-search-tree-iterator-java/ 
            BTNode node;
            node = new BTNode(8); //Root

            // Level - 1
            node.left = new BTNode(3);
            node.right = new BTNode(10);

            // Level - 2
            node.left.left = new BTNode(1);
            node.left.right = new BTNode(6);
            node.right.right = new BTNode(14);

            // Level - 3
            node.left.right.left = new BTNode(4);
            node.left.right.right = new BTNode(7);
            node.right.right.left = new BTNode(13);

            return node;
        }

        private int HeightOfBinaryTree(BTNode node)
        {
            if (node == null)
                return 0;

            int left = HeightOfBinaryTree(node.left);
            int right = HeightOfBinaryTree(node.right);

            return Math.Max(left + 1, right + 1);
        }

        private void Spiral_Order_Traversal_Of_BinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST_Spiral();
            SpiralOrderTraversalOfBinaryTree(node);
        }

        private BTNode ConstructTreeforBST_Spiral()
        {
            // BST Image is here
            BTNode node;
            node = new BTNode(1); //Root

            // Level - 1
            node.left = new BTNode(2);
            node.right = new BTNode(3);

            // Level - 2
            node.left.left = new BTNode(4);
            node.left.right = new BTNode(5);
            node.right.left = new BTNode(6);
            node.right.right = new BTNode(7);

            // Level - 3
            //node.left.right.left = new BTNode(4);
            //node.left.right.right = new BTNode(7);
            //node.right.right.left = new BTNode(13);

            return node;
        }

        private void SpiralOrderTraversalOfBinaryTree(BTNode node)
        {
            if (node == null)
                return;

            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            Spiral_PreOrderTraversal(node, 1, map);

            foreach(var item in map)
            {
                Console.WriteLine("");
                var list = item.Value;
                Console.Write("Level - " + item.Key +"  -->  ");
                foreach(var listItem in list)
                {
                    Console.Write(listItem + "-->");
                }
            }

            // Print binary tree from bottom to top//https://www.techiedelight.com/reverse-level-order-traversal-binary-tree/
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            for (int i = map.Count; i > 0; i--)
            {
                Console.WriteLine("");
                var list = map[i];
                Console.Write("Level - " + i + "  -->  ");
                for(int j = list.Count - 1; j >= 0; j--)
                {
                    Console.Write(list[j] + "-->");
                }
            }
        }
        private void Spiral_PreOrderTraversal(BTNode node, int level, Dictionary<int, List<int>> map)
        {
            if (node == null)
                return;

            if (!map.ContainsKey(level))
                map.Add(level, new List<int>());

            if (level % 2 != 0)
                map[level].Add(node.data);
            else
                map[level].Insert(0, node.data);

            Spiral_PreOrderTraversal(node.left, level + 1, map);
            Spiral_PreOrderTraversal(node.right, level + 1, map);
        }

        private void PrintNodes_TopDown_BottomUp_Approach_Click(object sender, EventArgs e)
        {
            BTNode root = new BTNode(1);
            root.left = new BTNode(2);
            root.right = new BTNode(3);
            root.left.left = new BTNode(4);
            root.left.right = new BTNode(5);
            root.right.left = new BTNode(6);
            root.right.right = new BTNode(7);
            root.left.left.left = new BTNode(8);
            root.left.left.right = new BTNode(9);
            root.left.right.left = new BTNode(10);
            root.left.right.right = new BTNode(11);
            root.right.left.left = new BTNode(12);
            root.right.left.right = new BTNode(13);
            root.right.right.left = new BTNode(14);
            root.right.right.right = new BTNode(15);

            TopDownApproach(root);
        }

        private void TopDownApproach(BTNode node)
        {
            if (node == null)
                return;

            Console.Write(node.data + ", ");
            Queue<BTNode> q1 = new Queue<BTNode>();
            Queue<BTNode> q2 = new Queue<BTNode>();

            q1.Enqueue(node.left);
            q2.Enqueue(node.right);

            while(q1.Count > 0)
            {
                var curr_q1 = q1.Dequeue(); ;
                Console.Write(curr_q1.data + ", ");
                if(curr_q1.left != null)
                    q1.Enqueue(curr_q1.left);
                if (curr_q1.right != null)
                    q1.Enqueue(curr_q1.right);

                var curr_q2 = q2.Dequeue();
                Console.Write(curr_q2.data + ", ");
                if (curr_q2.right != null)
                    q2.Enqueue(curr_q2.right);
                if (curr_q2.left != null)
                    q2.Enqueue(curr_q2.left);
            }
        }

        private void Bottom_View_Of_BinaryTree_Click(object sender, EventArgs e)
        {
            BTNodeHD root = new BTNodeHD(1);
            root.left = new BTNodeHD(2);
            root.right = new BTNodeHD(3);
            root.left.right = new BTNodeHD(4);
            root.right.left = new BTNodeHD(5);
            root.right.right = new BTNodeHD(6);
            root.right.left.left = new BTNodeHD(7);
            root.right.left.right = new BTNodeHD(8);

            var map = BottomViewOfBinaryTree(root);

            // Print Bottom View
            Console.WriteLine("Bottom View of Binary Tree: ");
            foreach(var pair in map)
            {
                Console.Write(pair.Value[pair.Value.Count - 1] + ", ");
            }
            Console.WriteLine("");
            // Print Top View
            Console.WriteLine("Top View of Binary Tree: ");
            foreach (var pair in map)
            {
                Console.Write(pair.Value[0] + ", ");
            }
        }

        private Dictionary<int, List<int>> BottomViewOfBinaryTree(BTNodeHD node)
        {
            if (node == null)
                return null;

            Queue<BTNodeHD> queue = new Queue<BTNodeHD>();
            queue.Enqueue(node);

            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
           
            while(queue.Count > 0)
            {
                var curr = queue.Dequeue();
                var currDist = curr.distane;
                if(!map.ContainsKey(currDist))
                {
                    map.Add(currDist, new List<int>());
                }  
                map[currDist].Add(curr.data);

                if(curr.left != null)
                {
                    curr.left.distane = curr.distane - 1;
                    queue.Enqueue(curr.left);
                }

                if(curr.right != null)
                {
                    curr.right.distane = curr.distane + 1;
                    queue.Enqueue(curr.right);
                }
            }
            return map;
        }

        private void Check_If_Given_Tree_IsBST_or_NOT_Click(object sender, EventArgs e)
        {
            BTNode root = ConstructTreeforIsSymmetic_1();
            Console.WriteLine("Is BST - " + IsBST(root, int.MinValue, int.MaxValue));
        }

        private bool IsBST(BTNode node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.data < min || node.data > max)
                return false;

            return IsBST(node.left, min, node.data) && IsBST(node.right, node.data, max);
        }
    }
}
