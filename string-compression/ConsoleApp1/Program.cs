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

            

            Dictionary<char, int> myCharCount = new Dictionary<char, int>();
            int count = 1;
            char myChar = chars[0];
            string myString = "" + chars[0];
            for(int i=0; i< chars.Length; i++)
            {

                if (chars[i] == myChar)
                {
                    count++;
                }
                else
                {
                    myString += "" + count;
                }

                //if (myCharCount.ContainsKey(c))
                //    myCharCount[c]++;
                //else
                //    myCharCount[c] = 1;
            }

            //string myString = "";
            //foreach (KeyValuePair<char,int> kp in myCharCount)
            //{
            //    if (kp.Value == 1)
            //    {
            //        myString += kp.Key + "";
            //    }
            //    else
            //    {
            //        myString += kp.Key + "" + kp.Value;
            //    }                    
            //}

            //myString.CopyTo(0, chars, 0, myString.Length);
            //int count = myString.Length;
            return count;
        }
    }
}
