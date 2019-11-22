using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFreak.Class
{
    public class BinaryTreeNode<T>
    {
        T data { get; set; }
        BinaryTreeNode<T> left, right;
    }

    public class BTNode
    {
        public int data;
        public BTNode left, right;

        public BTNode(int item)
        {
            data = item;
            left = right = null;
        }

        public BTNode()
        {
            data = -1;
            left = right = null;
        }
    }

    public class BTNodeHD
    {
        public int data;
        public int distane;
        public BTNodeHD left, right;

        public BTNodeHD(int item, int dist)
        {
            data = item;
            distane = dist;
            left = right = null;
        }

        public BTNodeHD(int item)
        {
            data = item;
            left = right = null;
        }
        public BTNodeHD()
        {
            data = -1;
            distane = 0;
            left = right = null;
        }
    }
}
