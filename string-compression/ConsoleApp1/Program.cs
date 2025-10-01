using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
            result = Compress(new char[] { 'a'});
            result = Compress(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
        }

        public static int Compress(char[] chars)
        {

            int write = 0;
            int read = 0;

            while (read < chars.Length)
            {
                char currentChar = chars[read];
                int count = 0;

                // Count the consecutive repeating characters
                while (read < chars.Length && chars[read] == currentChar)
                {
                    read++;
                    count++;
                }

                // Write the character
                chars[write++] = currentChar;

                // Write the count if it's greater than 1
                if (count > 1)
                {
                    // Convert the count to a string to handle multi-digit numbers
                    string sCount = count.ToString();
                    foreach (char c in sCount)
                    {
                        chars[write++] = c;
                    }
                }
            }

            return write;
        }
    }
}
