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
    public partial class xDailyCodingProblem_Hard : Form
    {
        Print print = new Print();
        public xDailyCodingProblem_Hard()
        {
            InitializeComponent();
        }

        private void Product_Of_Numbers_Except_Self_Click(object sender, EventArgs e)
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The Input array is:");
            print.PrintArray(input);
            var result = ProductOfNumbersExceptSelf(input);
            Console.WriteLine("The output array is:");
            print.PrintArray(result);
        }

        private int[] ProductOfNumbersExceptSelf(int[] arr)
        {
            if (arr == null)
                return null;

            int[] output = new int[arr.Length];

            int left = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                output[i] = left;
                left *= arr[i];
            }

            int right = 1;
            for(int i = arr.Length - 1; i >=0; i--)
            {
                output[i] *= right;
                right *= arr[i];
            }

            return output;
        }

        private void First_Missing_Positive_Click(object sender, EventArgs e)
        {
            var arr = new int[] { 1, -1, -5, -3, 3, 4, 2, 8 };
            var end = MoveNegativeNumbersToLast(arr);
            var res = FirstMissingPositiveInt(arr, end);
            Console.WriteLine(res);
        }

        private int MoveNegativeNumbersToLast(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return -1;

            int left = 0;
            int right = arr.Length - 1;

            while(left < right)
            {
                if(arr[left] <= 0 && arr[right] > 0)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else if(arr[left] > 0)
                {
                    left++;
                }
                else if(arr[right] <= 0)
                {
                    right--;
                }
            }
            return left;
        }

        private int FirstMissingPositiveInt(int[] arr, int end)
        {
            for(int i = 0; i<= end; i++)
            {
                int index = Math.Abs(arr[i]) - 1;
                if(index >=0 && index <= end && arr[index] > 0)
                    arr[index] = -arr[index];
            }

            for(int i = 0; i <= end; i++)
            {
                if (arr[i] > 0)
                    return i + 1;
            }
            return end + 1;
        }
    }
}
