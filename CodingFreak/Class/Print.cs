using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFreak.Class
{
    public class Print
    {
        public void PrintTreeInOrder(BTNode rootNode)
        {
            if (rootNode == null)
                return;
            PrintTreeInOrder(rootNode.left);
            Console.WriteLine(rootNode.data);
            PrintTreeInOrder(rootNode.right);
        }

        public void PrintTreePreOrder(BTNode rootNode)
        {
            if (rootNode == null)
                return;
            Console.WriteLine(rootNode.data);
            PrintTreeInOrder(rootNode.left);
            PrintTreeInOrder(rootNode.right);
        }

        public void PrintTreePostOrder(BTNode rootNode)
        {
            if (rootNode == null)
                return;
            
            PrintTreeInOrder(rootNode.left);
            PrintTreeInOrder(rootNode.right);
            Console.WriteLine(rootNode.data);
        }

        public void PrintArray(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
