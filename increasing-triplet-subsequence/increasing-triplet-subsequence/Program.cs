using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increasing_triplet_subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
            Debug.Assert(result == true);

            result = IncreasingTriplet(new int[] { 5, 4, 3, 2, 1 });
            Debug.Assert(result == false);

            result = IncreasingTriplet(new int[] { 2, 1, 5, 0, 4, 6 });
            Debug.Assert(result == true);

            result = IncreasingTriplet(new int[] { 6, 7, 1, 2 });
            Debug.Assert(result == false);

            result = IncreasingTriplet(new int[] { 0, 100, 10, 12, 5, 13 });
            Debug.Assert(result == true);
        }

        public static bool IncreasingTriplet(int[] nums)
        {
            // A triplet is not possible if the array has fewer than 3 elements.
            if (nums == null || nums.Length < 3)
            {
                return false;
            }

            // Initialize `small` and `mid` to the largest possible value.
            long smallestNum = long.MaxValue;
            long midNum = long.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                // We found the first small num
                if(nums[i] <= smallestNum)
                {
                    smallestNum = nums[i];
                }
                else if (nums[i] <= midNum)
                {
                    // found mid num
                    midNum = nums[i];
                }
                else
                {
                    // we found arry item that is > mid > smallest 
                    return true;
                }
            }

            return false;
        }
    }
}
