using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_vowels_of_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ReverseVowels("IceCreAm");
            Debug.Assert(result.Equals("AceCreIm"));

            result = ReverseVowels("leetcode");
            Debug.Assert(result.Equals("leotcede"));
        }

        public static string ReverseVowels(string s)
        {

            char[] vowelsSmall = { 'a', 'e', 'i', 'o', 'u' };
            char[] vowelsUpper = { 'A', 'E', 'I', 'O', 'U' };

            List<char> myFoundVowels = new List<char>();
            List<int> myFoundVowelsIndex = new List<int>();
            List<char> myFoundVowelsInReverse = new List<char>();

            // first find the vowel and its location
            for (int i = 0; i < s.Length; i++)
            {
                if (vowelsSmall.Contains(s[i]) || vowelsUpper.Contains(s[i]))
                {
                    myFoundVowels.Add(s[i]);
                    myFoundVowelsIndex.Add(i);
                }
            }

            // reverse the found vowel
            for (int i = myFoundVowels.Count -1; i >= 0; i--)
            {
                myFoundVowelsInReverse.Add(myFoundVowels[i]);
            }

            // replace them in the original string using its location
            var myStringArray = s.ToCharArray();
            for (int i = 0; i< myFoundVowelsIndex.Count; i++)
            {                
                myStringArray[myFoundVowelsIndex[i]] = myFoundVowelsInReverse[i];
            }

            return new string(myStringArray);
        }
    }
}
