using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace move_zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intArr = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(intArr);
            Debug.Assert(intArr.SequenceEqual(new int[]{1, 3, 12, 0, 0 }));

            intArr = new int[] { 0 };
            MoveZeroes(intArr);
            Debug.Assert(intArr.SequenceEqual(new int[] { 0 }));

            intArr = new int[] { -1, 0, 0, 1, 0 };
            MoveZeroes(intArr);
            Debug.Assert(intArr.SequenceEqual(new int[] { -1, 1, 0, 0, 0 }));

        }

        public static void MoveZeroes(int[] nums)
        {
            int i=0, j= 0;
            int countZero = 0;
            foreach (int n in nums)
            {
                if (n > 0 || n < 0)
                {
                    nums[i++] = n;
                }               
            }

            for (; i < nums.Length; i++)
            {
                nums[i] = 0;
            }



        }
    }
}
