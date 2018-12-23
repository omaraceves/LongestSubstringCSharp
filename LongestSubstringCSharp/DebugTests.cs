using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubstringCSharp
{
    public class DebugTests
    {
        /// <summary>
        /// Test1
        /// </summary>
        public static void Test1()
        {
            string s = "aabaab!bb";
            int result = 0;
            Solution solution = new Solution();
            result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(s);
            Console.WriteLine("Longest substring length is {0}", result);
        }

        /// <summary>
        /// Test2
        /// </summary>
        public static void Test2()
        {
            string s = "a";
            int result = 0;
            Solution solution = new Solution();
            result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(s);
            Console.WriteLine("Longest substring length is {0}", result);
        }

        /// <summary>
        /// Test3
        /// </summary>
        public static void Test3()
        {
            string s = "tmmzuxt";
            int result = 0;
            Solution solution = new Solution();
            result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(s);
            Console.WriteLine("Longest substring length is {0}", result);
        }

        /// <summary>
        /// Test4
        /// </summary>
        public static void Test4()
        {
            string s = "pwwkew";
            int result = 0;
            Solution solution = new Solution();
            result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(s);
            Console.WriteLine("Longest substring length is {0}", result);
        }

        /// <summary>
        /// Test5
        /// </summary>
        public static void Test5()
        {
            string s = "dvdf";
            int result = 0;
            Solution solution = new Solution();
            result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(s);
            Console.WriteLine("Longest substring length is {0}", result);
        }

        /// <summary>
        /// Test6
        /// </summary>
        public static void Test6()
        {
            string s = " ";
            int result = 0;
            Solution solution = new Solution();
            result = solution.LengthOfLongestSubstring(s);
            Console.WriteLine(s);
            Console.WriteLine("Longest substring length is {0}", result);
        }
    }
}
