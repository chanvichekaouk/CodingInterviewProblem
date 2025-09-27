using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_of_array_except_self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });
            Debug.Assert(result.SequenceEqual(new int[] { 0, 0, 9, 0, 0 }));

            result = ProductExceptSelf(new int[] { 1, 2, 3, 4 });
            Debug.Assert(result.SequenceEqual(new int[] { 24, 12, 8, 6 }));
        }

        public static int[] ProductExceptSelf(int[] nums)
        {

            int[] answers = new int[nums.Length];

            // left to right with left or suffix multiply as result of each walking index
            int suffixMultiply = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                answers[i] = suffixMultiply;
                suffixMultiply *= nums[i];
            }

            // right to left with right side multiply or posfix multiply as result of each walking index
            int postfixMultiply = 1;            
            for (int i = nums.Length -1; i >=0 ; i--)
            {
                answers[i] *= postfixMultiply;
                postfixMultiply *= nums[i];
            }

            return answers;

        }
    }
}
