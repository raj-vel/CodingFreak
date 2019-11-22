using CodingFreak.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingFreak
{
    public partial class Array : Form
    {
        Print print = new Print();
        public Array()
        {
            InitializeComponent();
        }

        private int[] MoveZerosToFirst(int[] arr)
        {
            int k = arr.Length - 1;
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
                    k--;
                }
            }

            return arr;
        }

        private int[] MoveZerosToLast(int[] arr)
        {
            int k = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
                    k++;
                }
            }

            return arr;
        }

        private void Merge_Two_Sorted_Arrays_Click(object sender, EventArgs e)
        {
            // How will you merge two sorted arrays. The first array has enough empty spaces to accomodate the second array.
            //int[] mPlusN = new int[] {2, 8, -1, -1, -1, 13, -1, 15, 20};
            int[] mPlusN = new int[] { 10, 12, 13, 14, 18, -1, -1, -1, -1, -1 };
            int[] N = new int[] { 16, 17, 19, 20, 22 };
            var xx = MergeTwoSortedArrays(mPlusN, N);
            //https://www.geeksforgeeks.org/sorted-merge-one-array/
        }

        private int[] MergeTwoSortedArrays(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr1.Length < 1 || arr2 == null || arr2.Length < 1)
                return null;

            if (arr1 == null || arr1.Length < 1)
                return arr2;

            if (arr2 == null || arr2.Length < 1)
                return arr1;

            int index = 4;
            int arr1_n = arr1.Length - 1;
            int arr2_n = arr2.Length - 1;

            while(index >= 0 && arr1_n >= 0 && arr2_n >= 0)
            {
                if(arr1[index] > arr2[arr2_n])
                {
                    //Swap
                    int temp = arr1[index];
                    arr1[index--] = arr1[arr1_n];
                    arr1[arr1_n--] = temp;
                }
                else
                {
                    arr1[arr1_n--] = arr2[arr2_n--];
                }
            }

            // if any elements remains in 2nd array
            while (arr2_n >= 0)
            {
                arr1[arr1_n--] = arr2[arr2_n--];
            }


            var x = arr1;
            return x;
        }

        private void Print_All_SubArray_With_Sum_Zero_Click(object sender, EventArgs e)
        {
            // https://www.techiedelight.com/find-sub-array-with-0-sum/
            var arr = new int[] { 4, 2, -3, -1, 0, 4 };
            PrintAllSubArrayWithSumZero(arr);
        }

        private void PrintAllSubArrayWithSumZero(int[] arr)
        {
            Dictionary<int, List<int>> list = new Dictionary<int, List<int>>();
            PrintAllSubArrayWithSumZero_Insert(list, 0, -1);
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if(list.ContainsKey(sum))
                {
                    Console.WriteLine("");
                    var listVal = list[sum];
                    foreach (var x in listVal)
                        Console.Write(arr[x+1] + "..." + arr[i]);
                }

                PrintAllSubArrayWithSumZero_Insert(list, sum, i);
            }
            
        }

        private void PrintAllSubArrayWithSumZero_Insert(Dictionary<int, List<int>> list, int key, int value)
        {
            if(!list.ContainsKey(key))
            {
                list.Add(key, new List<int>());
            }
            list[key].Add(value);
        }

        private void Longest_Consecutive_SubArray_Click(object sender, EventArgs e)
        {
            var arr = new int[] { 100, 4, 200, 1, 3, 2 };
            LongestConsecutiveSubArray(arr);

            /*
             First turn the input into a set of numbers. That takes O(n) and then we can ask in O(1) whether we have a certain number.
             Then go through the numbers. If the number x is the start of a streak (i.e., x-1 is not in the set), 
             then test y = x+1, x+2, x+3, ... and stop at the first number y not in the set. The length of the streak is then simply y-x 
             and we update our global best with that. Since we check each streak only once, this is overall O(n). 
             */
        }

        private void LongestConsecutiveSubArray(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return;
            // int start = -1, end = -1;
            HashSet<int> hash = new HashSet<int>();
            foreach (var i in arr)
                hash.Add(i);
            int sum = 0;
            foreach(var n in hash)
            {
                if(!hash.Contains(n-1))
                {
                    int m = n + 1;
                    while(hash.Contains(m))
                    {
                        m++;
                    }
                    //if (m - n > sum)
                    //{
                    //    start = m;
                    //    end = n;
                    //}
                    sum = Math.Max(sum, m - n);
                }
            }
            // Console.WriteLine(sum+", " + start +", " + end);
            Console.WriteLine(sum);
        }

        private void Maximum_Length_SubArray_OfSize_K_Click(object sender, EventArgs e)
        {
            // https://www.techiedelight.com/find-maximum-length-sub-array-having-given-sum/
            MaxLengthSubArrayOfSize_K(new int[] {5, 6, -5, 5, 3, 5, 3, -2, 0}, 8);
        }

        private void MaxLengthSubArrayOfSize_K(int[] arr, int K)
        {
            if (K < 1 || arr == null || arr.Length < 1)
                return;

            int sum = 0, endingIndex = 0, maxLen = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (!map.ContainsKey(sum))
                    map.Add(sum, i);

                if(map.ContainsKey(sum -K) && maxLen < i - map[sum - K])
                {
                    maxLen = i - map[sum - K];
                    endingIndex = i;
                }
            }

            Console.WriteLine($"The longest SubArray is from the Index [{endingIndex - maxLen + 1}....{endingIndex}]");
        }

        private void Maximum_Length_SubArray_With_Equal_0and1_Click(object sender, EventArgs e)
        {
            MaxLengthSubArrayWithEqual_0and1(new int[] { 0, 0, 1, 0, 1, 0, 0 });
        }

        private void MaxLengthSubArrayWithEqual_0and1(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return;

            int sum = 0, maxLen = 0, endingIndex = -1;
            Dictionary<int, int> map = new Dictionary<int, int>();

            map.Add(0, -1);

            for(int i = 0; i < arr.Length; i++)
            {
                sum += (arr[i] == 0) ? -1 : 1;
                if (!map.ContainsKey(sum))
                    map.Add(sum, i);

                if(map.ContainsKey(sum) && maxLen < i-map[sum])
                {
                    maxLen = i - map[sum];
                    endingIndex = i;
                }
            }
            Console.WriteLine($"The longest subarray of 0's and 1's is starting at index [{endingIndex - maxLen + 1}]....[{endingIndex}]");
        }

        private void Inplace_Merge_TwoArrays_Click(object sender, EventArgs e)
        {
            InplaceMergeOfTwoArrays(new int[] { 1, 4, 7, 8, 10 }, new int[] { 2, 3, 9 });
        }

        private void InplaceMergeOfTwoArrays(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null || arr1.Length < 1 || arr2.Length < 1)
                return;

            Console.WriteLine("Printing before Sort - 1");
            print.PrintArray(arr1);
            Console.WriteLine("Printing before sort - 2");
            print.PrintArray(arr2);

            for (int i = 0; i< arr1.Length; i++)
            {
                if(arr1[i] > arr2[0])
                {
                    int temp = arr1[i];
                    arr1[i] = arr2[0];
                    arr2[0] = temp;
                }

                int first = arr2[0];
                int j;
                for(j = 1; j < arr2.Length && arr2[j] < first; j++)
                {
                    arr2[j - 1] = arr2[j];
                }
                arr2[j - 1] = first;
            }

            Console.WriteLine("Printing Sorted array - 1");
            print.PrintArray(arr1);
            Console.WriteLine("Printing Sorted array - 2");
            print.PrintArray(arr2);
        }

        private void Merge_Second_Array_To_First_Click(object sender, EventArgs e)
        {
            var X = MoveZerosToFirst(new int[] { 0, 2, 0, 3, 0, 5, 6, 0, 0 });
            var Y = new int[] { 1, 8, 9, 10, 15 };
            MergeSecondArrayToFirst(X, Y);
        }

        
        private void MergeSecondArrayToFirst(int[] X, int[] Y)
        {
            int count = 0;
            while(X[count] == 0)
            {
                count++;
            }
            int startIndex = count - 1;
            int xLen = X.Length - 1;
            int yLen = Y.Length - 1;


            int k = startIndex + yLen;
            
            while(startIndex >= 0 && yLen >= 0)
            {
                if(X[startIndex] > Y[yLen])
                {
                    X[k] = X[startIndex];
                    k--;
                    startIndex--;
                }
                else
                {
                    X[k] = Y[yLen];
                    k--;
                    yLen--;
                }
            }

            while(yLen >= 0)
            {
                X[k] = Y[yLen];
                k--;
                yLen--;
            }

            print.PrintArray(X);
        }

        private void Find_Index_Of_Zero_Tobe_Replaced_To_Get_Max_Count_Of_Ones_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
            Console.WriteLine("Find Index Of Zero Tobe Replaced To Get Max Count Of Ones");
            print.PrintArray(arr);
            var res = FindIndexOfZeroToBeReplced(arr);
            Console.WriteLine("The index to be replaced is - " + res);
        }

        private int FindIndexOfZeroToBeReplced(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return -1;

            int count = 0;
            int maxCount = 0;

            int prevZeroIndex = -1;
            int maxIndex = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    count++;
                else
                {
                    count = i - prevZeroIndex;
                    prevZeroIndex = i;
                }

                if(count > maxCount)
                {
                    maxCount = count;
                    maxIndex = prevZeroIndex;
                }
            }

            return maxIndex;
        }

        private void Find_Maximum_Product_Of_Two_Elements_In_an_Array_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { -10, -3, 5,6,-2 };
            Console.WriteLine("Find Index Of Zero Tobe Replaced To Get Max Count Of Ones");
            print.PrintArray(arr);
            FindMaximumProductOfTwoElementsInAnArray(arr);
        }

        private void FindMaximumProductOfTwoElementsInAnArray(int[] arr)
        {
            if (arr == null || arr.Length < 1)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int max1 = arr[0], max2 = int.MinValue;
            int min1 = arr[0], min2 = int.MaxValue;

            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if(arr[i] > max2)
                {
                    max2 = arr[i];
                }

                if(arr[i] < min1)
                {
                    min2 = min1;
                    min1 = arr[i];
                }
                else if(arr[i] < min2)
                {
                    min2 = arr[i];
                }
            }

            if(max1 * max2 > min1*min2)
            {
                Console.WriteLine($"The product of {max1} and {max2} is highest");
            }
            else
            {
                Console.WriteLine($"The product of {min1} and {min2} is highest");
            }
        }

        private void GetPopularFeature_Click(object sender, EventArgs e)
        {

        }

        public List<string> PopularFeature(int numFeature, int topFeatures, List<string> possibleFeatures, int numFeaturesRequest, List<string> featureRequests)
        {
            if (numFeature < topFeatures || numFeature < numFeaturesRequest || topFeatures < 1 || numFeature < 1 || numFeaturesRequest < 1)
                return new List<string>();

            if(possibleFeatures == null || possibleFeatures.Count < 1 || possibleFeatures.Count != numFeature || possibleFeatures.Count < numFeature)
            {
                return new List<string>();
            }

            if(featureRequests == null || featureRequests.Count < 1 || featureRequests.Count != numFeaturesRequest || featureRequests.Count < numFeature)
            {
                return new List<string>();
            }

            int firstMax = 0, secondMax = 0;
            var possibleFeaturesDict = new Dictionary<string, int>();
            var retList = new List<string>();
            foreach(var feature in possibleFeatures)
            {
                int curCount = 0;
                foreach(var featureReq in featureRequests)
                {
                    if (featureReq.LastIndexOf(feature) > -1)
                        curCount++;
                }
                if(curCount > firstMax)
                {
                    retList[1] = retList[0];
                    retList[0] = feature;
                }
                else if(curCount > firstMax)
                {
                    retList[1] = feature;
                }
                if(possibleFeaturesDict.Count > 2)
                {

                }
                else
                {

                }
                possibleFeaturesDict.Add(feature, 0);
            }
        }
    }
}
