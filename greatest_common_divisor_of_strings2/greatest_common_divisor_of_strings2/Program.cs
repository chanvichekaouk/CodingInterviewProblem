using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatest_common_divisor_of_strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = GcdOfStrings("ABCABC", "ABC");
            Debug.Assert(result.Equals("ABC"));

            result = GcdOfStrings("ABABAB", "ABAB");
            Debug.Assert(result.Equals("AB"));

            result = GcdOfStrings("LEET", "CODE");
            Debug.Assert(result.Equals(""));

            result = GcdOfStrings("ABCDEF", "ABC");
            Debug.Assert(result.Equals(""));
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return "";

            int lengthStr1 = str1.Length;
            int lengthStr2 = str2.Length;

            int gcd = 0;
            while (lengthStr2 != 0)
            {
                int temp = lengthStr2;
                lengthStr2 = lengthStr1 % lengthStr2;
                lengthStr1 = temp;
            }

            gcd = lengthStr1;

            string stringGCD = str1.Substring(0, gcd);
            var result1 = str1.Replace(stringGCD, "");
            var result2 = str2.Replace(stringGCD, "");

            if (string.IsNullOrEmpty(result1) && string.IsNullOrEmpty(result2))
            {
                return stringGCD;
            }
            else
            {
                return "";
            }
        }
    }
}
