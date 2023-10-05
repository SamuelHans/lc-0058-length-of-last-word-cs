using System.Text.RegularExpressions;
using System;

namespace LC_0058_LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Given a string s consisting of words and spaces, return the length of the last word in the string.

            A word is a maximal 
            substring
             consisting of non-space characters only.
            
            Example 1:
            Input: s = "Hello World"
            Output: 5
            Explanation: The last word is "World" with length 5.

            Example 2:
            Input: s = "   fly me   to   the moon  "
            Output: 4
            Explanation: The last word is "moon" with length 4.
            
            Example 3:
            Input: s = "luffy is still joyboy"
            Output: 6
            Explanation: The last word is "joyboy" with length 6.
             
            
            Constraints:
            
            1 <= s.length <= 104
            s consists of only English letters and spaces ' '.
            There will be at least one word in s.
            */

            //var s = "Hello World";
            var s = "   fly me   to   the moon  ";
            var orig = s;
            //var s = "luffy is still joyboy";

            // \s means any whitespace character. + is matches the preceding character one or more times zo and zoo, but not z


            Console.WriteLine("The length of the last word in \"{0}\" is {1}", orig, Solution.LengthOfLastWord(s));
        }

        public class Solution
        {
            public static int LengthOfLastWord(string s)
            {
                s = Regex.Replace(s, @"\s+", " ");

                s = s.Trim();

                var arrayWords = s.Split(' ');

                return arrayWords.Last().Length;
            }
        }
    }
}