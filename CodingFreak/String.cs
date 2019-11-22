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
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void Find_Longest_Palindrome_Click(object sender, EventArgs e)
        {
            // The idea is very simple and effective. 
            // For each character in the given string, we consider it as mid point of a palindrome and expand in both directions to find maximum length palindrome. 
            // For even length palindrome, we consider every adjacent pair of characters as mid point.

            string input = "bananas";
            var palindrome = FindLongestPalindrome(input);
            Console.WriteLine($"The longest Palindrome for {input} is {palindrome}");

            // https://www.techiedelight.com/longest-palindromic-substring-non-dp-space-optimized-solution/
        }

        private string FindLongestPalindrome(string str)
        {
            int n = str.Length - 1;
            string maxPalindrome = string.Empty;

            for(int i = 0; i < n; i++)
            {
                string currPalindrome = ExpandForPalindrome(str, i, i);
                if(currPalindrome.Length > maxPalindrome.Length)
                {
                    maxPalindrome = currPalindrome;
                }

                currPalindrome = ExpandForPalindrome(str, i, i+1);
                if (currPalindrome.Length > maxPalindrome.Length)
                {
                    maxPalindrome = currPalindrome;
                }
            }
            return maxPalindrome;
        }

        private string ExpandForPalindrome(string str, int low, int high)
        {
            string palindrome = "";
            while(low >= 0 && high < str.Length && str[low] == str[high])
            {
                palindrome = str.Substring(low, high - low + 1);
                low--;
                high++;
            }
            return palindrome;
        }

        private void Is_Rotated_Palindrome_Or_Not_Click(object sender, EventArgs e)
        {
            //The problem is similar to finding Longest Palindrome
            //Let the given string be S of length m. The idea is to concatenate the given string with itself i.e S = S + S
            //  and find palindromic substring of length m in the modified string 

            string input = "CBAABCDCBAABCD";
            var palindrome = IsRotatedPalindrome(input);
            Console.WriteLine($"The Rotated Palindrome for {input} is {palindrome.ToString()}");
            // https://www.techiedelight.com/check-given-string-rotated-palindrome-not/
        }

        private bool IsRotatedPalindrome(string str)
        {
            return IsLongestPalindromeMatchesLength(str + str, str.Length);
        }

        private bool IsLongestPalindromeMatchesLength(string str, int K)
        {
            for(int i = 0; i < str.Length-1; i++)
            {
                if (IsExpandForPalindrome(str, i, i, K) || IsExpandForPalindrome(str, i, i + 1, K))
                    return true;
            }
            return false;
        }

        private bool IsExpandForPalindrome(string str, int low, int high, int K)
        {
            while (low >= 0 && high < str.Length && str[low] == str[high])
            {
                if(high-low+1 == K)
                    return true;

                low--;
                high++;
            }
            return false;
        }

        private void Check_For_Repeated_SubSequence_Click(object sender, EventArgs e)
        {
            //String XYBAXB has XB(XBXB) as repeated sub - sequence
            //String XBXAXB has XX(XXX) as repeated sub-sequence

            // The idea is very simple. If we discard all non - repeating elements from the string(having frequency of 1) and the resulting string is non - Palindrome, 
            // then the string contains a repeated subsequence.If the resulting string is a palindrome and don’t have any character with frequency 3 or more, the string cannot have repeated subsequence.

            string input = "XYBAXB";
            var res = CheckForRepeatedSubsequence(input);
            Console.WriteLine($"The Check For Repeated Subsequence for {input} is {res}");
        }

        private bool CheckForRepeatedSubsequence(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach(char c in str)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq.Add(c, 1);
            }

            var res = freq.Count(x => x.Value >= 3);
            if (res > 0)
                return true;

            StringBuilder sb = new StringBuilder();
            foreach(var c in str)
            {
                if (freq[c] >= 2)
                    sb.Append(c);
            }

            return !IsPalindrome(sb.ToString(), 0, sb.Length - 1);
        }

        private bool IsPalindrome(string str, int low, int high)
        {
            if (low >= high)
                return true;

            return (str[low] == str[high] && IsPalindrome(str, low + 1, high - 1));
        }
        private bool IsPalindrome_V2(string str, int low, int high)
        {
            if (low >= high)
                return true;

            if (str[low] == str[high])
            {
                return IsPalindrome_V2(str, low + 1, high - 1);
            }
            return false;
        }

        private void Is_Palindrome_Click(object sender, EventArgs e)
        {
            string str1 = "amma";
            Console.WriteLine($"The string {str1} is Palindrome - { IsPalindrome_V2(str1, 0, str1.Length - 1)}");

            string str2 = "banana";
            Console.WriteLine($"The string {str2} is Palindrome - { IsPalindrome_V2(str2, 0, str2.Length - 1)}");
        }

        private void Convert_Number_To_String_Like_Excel_Click(object sender, EventArgs e)
        {

        }

        private string ConvertNumberToSring_Excel(int num)
        {
            if (num < 1)
                return "";

            int baseValue = 26;
            int initialValue = (int)'A';
            num = num - 1;
            string retValue = "";
            while(num > 0)
            {
                retValue = (num % 26) + initialValue + retValue;
                num = (num / 26) - 1;
            }
            return retValue;
        }

        private int ConvertStringToNumber_Excel(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            int baseValue = 26;
            int initialValue = (int)'A' - 1;
            int retValue = 0;

            foreach (char c in str)
            {
                retValue *= 26;
                retValue += (int)c - initialValue;
            }

            return retValue;
        }
    }
}
