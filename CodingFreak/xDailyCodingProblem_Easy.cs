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
    public partial class xDailyCodingProblem_Easy : Form
    {
        public xDailyCodingProblem_Easy()
        {
            InitializeComponent();
        }

        private void TwoNumbersAddToK_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 10, 15, 3, 7 };
            int K = 17;
            TwoNumbersInArrayAddToK(arr, K);
        }

        private void TwoNumbersInArrayAddToK(int[] arr, int K)
        {
            if (arr == null || arr.Length < 2 || K < 2)
                return;

            bool isFound = false;
            Dictionary<int, int> list = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                int x = Math.Abs(K - arr[i]);
                if(list.ContainsKey(x))
                {
                    Console.WriteLine($"{x} and {arr[i]} forms {K}");
                    isFound = true;
                }
                else
                {
                    list.Add(arr[i], arr[i]);
                }
            }

            if (!isFound)
                Console.WriteLine("No addition of numbers found for K in this array");
        }
    }
}
