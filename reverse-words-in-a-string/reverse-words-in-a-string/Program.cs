using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_words_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ReverseWords("the sky is blue");
            Debug.Assert(result.Equals("blue is sky the"));

            result = ReverseWords("  hello world  ");
            Debug.Assert(result.Equals("world hello"));

            result = ReverseWords("a good   example");
            Debug.Assert(result.Equals("example good a"));
        }

        public static string ReverseWords(string s)
        {
            s = s.Trim();
            string[] sArr= s.Split(' ');

            string reversedWord = "";
            for (int i = sArr.Length -1; i >= 0; i--)
            {
                if(string.IsNullOrEmpty(sArr[i]))
                    continue;

                reversedWord += sArr[i] + " "; 
            }

            return reversedWord.Trim();
        }
    }
}
