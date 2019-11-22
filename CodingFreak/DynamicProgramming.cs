using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingFreak
{
    public partial class DynamicProgramming : Form
    {
        public DynamicProgramming()
        {
            InitializeComponent();
        }

        private void Subset_Sum_Present_In_Array_or_Not_Click(object sender, EventArgs e)
        {
            // Given a set of non-negative integers, and a value sum, determine if there is a subset of the given set with sum equal to given sum.
            // Input: set[] = { 3, 34, 4, 12, 5, 2 }, sum = 9
            // Output: True  //There is a subset (4, 5) with sum 9.

            int[] set = { 3, 34, 4, 12, 5, 2 };
            int sum = 9;

            var x = SubsetSumIsPresentInArrayOrNot(set, sum);
            var y = x;
        }

        private bool SubsetSumIsPresentInArrayOrNot(int[] arr, int sum)
        {
            int n = arr.Length;
            bool[,] dp = new bool[n+1, sum+1];

            for(int i = 0; i<=n; i++)
            {
                dp[i, 0] = true;
            }
            for(int i=1; i<=sum; i++)
            {
                dp[0, i] = false;
            }

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j<=sum; j++)
                {
                    if(j < arr[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    if(j >= arr[i-1])
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - arr[i - 1]];
                    }
                }
            }

            return dp[n, sum];
        }

        private void Fibonacci_Number_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Fib(10));
            //var dict = new Dictionary<int, int>();
            //dict.Add(0, 0);
            //dict.Add(1, 1);
            //Console.WriteLine(Fib(10, dict));
            //Console.WriteLine(Fib_iterative(10));

            var monthColumns = new List<(string Name, decimal Value)>
                                {
                                    ("Jul", 1),
                                    ("Aug", 2),
                                    ("Sep", 3),
                                    ("Oct", 4),
                                    ("Nov", 5),
                                    ("Dec", 6),
                                    ("Jan", 7),
                                    ("Feb", 8),
                                    ("Mar", 9),
                                    ("Apr", 10),
                                    ("May", 11),
                                    ("Jun", 12)
                                };

            foreach(var (name, value) in monthColumns)
            {
                Console.WriteLine("Name - " + name + " && Value - " + value);
            }
        }

        private int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fib(n - 1) + Fib(n - 2);
        }

        private int Fib(int n, Dictionary<int, int> cache)
        {
            if (cache.ContainsKey(n))
                return cache[n];

            cache[n] = Fib(n - 1, cache) + Fib(n - 2, cache);
            return cache[n];
        }

        private int Fib_iterative(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            for(int i = 1; i<n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        private void Coin_Change_Problem_Click(object sender, EventArgs e)
        {
            int[] coins = new int[] { 25, 10, 5, 1 };
            Console.WriteLine("The minimum coins required in change for {1} is " + CoinChange_Iterative(coins, 1));
            Console.WriteLine("The minimum coins required in change for {6} is " + CoinChange_Iterative(coins, 6));
            Console.WriteLine("The minimum coins required in change for {49} is " + CoinChange_Iterative(coins, 49));
            Console.WriteLine("DP");
            Console.WriteLine("The minimum coins required in change for {6} is " + MakeChange_DP(6, coins));
            Console.WriteLine("The minimum coins required in change for {49} is " + MakeChange_DP(49, coins));
        }

        private int CoinChange_Iterative(int[] coins, int c)
        {
            int minCoins = 0;
            int index = 0;
            while(c > 0 && index < coins.Length)
            {
                if(c >= coins[index])
                {
                    c -= coins[index];
                    minCoins++;
                }
                else
                {
                    index++;
                }
            }

            return minCoins;
        }

        private int MakeChange_DP(int c, int[] coins)
        {
            int[] cache = new int[c + 1];

            for(int i = 1; i<=c;i++)
            {
                int minCoins = int.MaxValue;
                foreach(int coin in coins)
                {
                    if((i - coin) >= 0)
                    {
                        int currCoins = cache[i - coin] + 1;
                        if(currCoins < minCoins)
                        {
                            minCoins = currCoins;
                        }
                    }
                }

                cache[i] = minCoins;
            }

            return cache[c];
        }

        private void Stairs_Claim_1And2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("The stairs claim for {1,2} in steps 3 is " + StairsClaim_Rec(3));
            Console.WriteLine("The stairs claim for {1,2} in steps 4 is " + StairsClaim_Rec(4));
            Console.WriteLine("The stairs claim for {1,2} in steps 5 is " + StairsClaim_Rec(5));
            Console.WriteLine("The stairs claim for {1,2} in steps 6 is " + StairsClaim_Rec(6));
            Console.WriteLine("DP");
            Console.WriteLine("The stairs claim for {1,2} in steps 3 in DP is " + StairClaim_DP(3));
            Console.WriteLine("The stairs claim for {1,2} in steps 4 in DP is " + StairClaim_DP(4));
            Console.WriteLine("The stairs claim for {1,2} in steps 5 in DP is " + StairClaim_DP(5));
            Console.WriteLine("DP Iterative");
            Console.WriteLine("The stairs claim for {1,2} in steps 3 in DP Iterative is " + StairsClaim_DP_Iterative(3));
            Console.WriteLine("The stairs claim for {1,2} in steps 4 in DP Iterative is " + StairsClaim_DP_Iterative(4));
            Console.WriteLine("The stairs claim for {1,2} in steps 5 in DP Iterative is " + StairsClaim_DP_Iterative(5));
        }

        private int StairsClaim_Rec(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (n == 2)
                return 2;

            return StairsClaim_Rec(n - 1) + StairsClaim_Rec(n - 2);
        }

        private int StairClaim_DP(int n)
        {
            int[] cache = new int[n+1];
            cache[0] = 0;
            cache[1] = 1;
            cache[2] = 2;
            return StairsClaim_DP(n, cache);
        }

        private int StairsClaim_DP(int n, int[] cache)
        {
            if (n <= 0)
                return cache[0];
            else if (n == 1)
                return cache[1];
            else if (n == 2)
                return cache[2];

            cache[n] = StairsClaim_DP(n-1, cache) + StairsClaim_DP(n-2, cache);
            return cache[n];
        }

        private int StairsClaim_DP_Iterative(int n)
        {
            int[] cache = new int[n+1];
            cache[0] = 0;
            cache[1] = 1;
            cache[2] = 2;

            if (n == 0)
                return cache[0];
            else if (n == 1)
                return cache[1];
            else if (n == 2)
                return cache[2];

            for(int i = 3; i<=n; i++)
            {
                cache[i] = cache[i - 1] + cache[i - 2];
            }

            return cache[n];
        }

        private void Square_Submatrix_Click(object sender, EventArgs e)
        {

        }

        private void SquareSubmatrix_Rec(bool[,] matrix)
        {
            int res = 0;
            for(int i = 0; i< matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == true)
                    {
                        res = Math.Max(res, Calc_SquareSubMatrix(matrix, i, j));
                    }
                }
            }

            Console.WriteLine("For the given matrix the square of submatrix length - " + res);
        }

        private int Calc_SquareSubMatrix(bool[,] matrix, int i, int j)
        {
            if (i == matrix.GetLength(0) || j == matrix.GetLength(1) || matrix[i,j] == false)
                return 0;

            return 1 + Math.Min( Math.Min(Calc_SquareSubMatrix(matrix, i + 1, j) 
                    , Calc_SquareSubMatrix(matrix, i, j + 1))
                    , Calc_SquareSubMatrix(matrix, i + 1, j + 1));
        }

        private void SquareSubmatrix_Rec_Cache(bool[,] matrix)
        {
            int res = 0;
            int[,] cache = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == true)
                    {
                        res = Math.Max(res, Calc_SquareSubMatrix_Cache(matrix, i, j, cache));
                    }
                }
            }

            Console.WriteLine("For the given matrix the square of submatrix length - " + res);
        }

        private int Calc_SquareSubMatrix_Cache(bool[,] matrix, int i, int j, int[,] cache)
        {
            if (i == matrix.GetLength(0) || j == matrix.GetLength(1) || matrix[i, j] == false)
                return 0;

            if(cache[i,j] > 0)
            {
                return cache[i, j];
            }

            cache[i,j] = 1 + Math.Min(Math.Min(Calc_SquareSubMatrix_Cache(matrix, i + 1, j, cache)
                    , Calc_SquareSubMatrix_Cache(matrix, i, j + 1, cache))
                    , Calc_SquareSubMatrix_Cache(matrix, i + 1, j + 1, cache));

            return cache[i, j];
        }

        private int SquareSubmatrix_Iterative(bool[,] matrix)
        {
            int max = 0;
            int[,] cache = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < cache.GetLength(0); i++)
            {
                for (int j = 0; j < cache.GetLength(1); j++)
                {
                    // If we’re in the first row/column then
                    // the value is just 1 if that cell is
                    // true and 0 otherwise. In other rows and
                    // columns need to look up and to the left
                    if (i == 0 || j == 0)
                    {
                        cache[i,j] = matrix[i,j] ? 1 : 0;
                    }
                    else if (matrix[i,j])
                    {
                        cache[i,j] = Math.Min(Math.Min(cache[i,j - 1],
                        cache[i - 1, j]),
                        cache[i - 1, j - 1]) + 1;
                    }
                    if (cache[i, j] > max) max = cache[i, j];
                }
            }

            return max;
        }
    }
}
