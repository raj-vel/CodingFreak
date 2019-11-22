using CodingFreak.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingFreak
{
    public partial class xDailyCodingProblem_Medium : Form
    {
        Print print = new Print();
        public xDailyCodingProblem_Medium()
        {
            InitializeComponent();
        }

        private BTNode ConstructTreeToSerialize()
        {
            BTNode node;
            node = new BTNode(45);

            node.left = new BTNode(25);
            node.left.left = new BTNode(15);
            node.left.right = new BTNode(35);

            node.right = new BTNode(75);
            node.right.right = new BTNode(88);
            return node;
        }

        private void Searialize_Desearialize_BinnaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeToSerialize();
            var str = SerializeBinaryTree(node);
            Console.WriteLine(str);
            Queue<string> q = new Queue<string>();
            var arr = str.Split(',').ToList();
            arr.ForEach(q.Enqueue);
            var res = DeserializeBinaryTree(q);
            print.PrintTreePreOrder(res);
        }
        private string SerializeBinaryTree(BTNode node)
        {
            if (node == null)
                return "null,";

            StringBuilder sb = new StringBuilder();
            sb.Append(node.data);
            sb.Append(",");
            sb.Append(SerializeBinaryTree(node.left));
            sb.Append(SerializeBinaryTree(node.right));

            return sb.ToString();
        }

        private BTNode DeserializeBinaryTree(Queue<string> queue)
        {
            string currVal = queue.Dequeue();
            if (currVal == "null")
                return null;

            BTNode node = new BTNode(Convert.ToInt32(currVal));
            node.left = DeserializeBinaryTree(queue);
            node.right = DeserializeBinaryTree(queue);

            return node;
        }
    }
}
