using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubstringCSharp
{
    /// <summary>
    /// Solution
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Length of longest substring
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int start = -1; //start represents a position where last duplicated char was seen, it'll take -1 value at first
            int max = 0;
            int index = 0;
            Dictionary<int, int> table = new Dictionary<int, int>();

            for (int i = 0; i <= (s.Length - 1); i++)
            {
                //If char is duplicated
                if (table.ContainsKey(s[i]))
                {
                    //Get latest position where char was captured
                    index = table[s[i]];

                    //If latest char's position is greater than start then move start to that position 
                    if (index > start)
                    {
                        start = index;
                    }

                    //Put current char position
                    table[s[i]] = i;
                }
                else //Char is not duplicated
                {
                    //Add char and char's position to table
                    table.Add(s[i], i);
                }

                //calculate max length
                max = Math.Max(max, i - start);
            }

            return max;
        }
    }
}
