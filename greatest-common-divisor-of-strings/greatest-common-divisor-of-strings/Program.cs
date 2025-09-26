using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace greatest_common_divisor_of_strings
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task<string> myTask = GcdOfStrings("ABCABC", "ABC");
            string result = await myTask;
            Debug.Assert(result.Equals("ABC"));

            myTask = GcdOfStrings("ABABAB", "ABAB");
            result = await myTask;
            Debug.Assert(result.Equals("AB"));

            myTask = GcdOfStrings("LEET", "CODE");
            result = await myTask;
            Debug.Assert(result.Equals(""));
        }

        public static async Task<string> GcdOfStrings(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return "";
            }

            char[] str1CharArray = str1.ToCharArray();

            string strToTest = "";
            foreach (char c in str1CharArray)
            {
                if (strToTest.Equals(str2))
                {
                    strToTest = "" + c;
                }
                else
                {
                    strToTest += c;
                }
            }

            if (strToTest.Equals(str1))
            {
                return "";
            }
            else
            {
                return strToTest;
            }
                
        }
    }
}
