using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kids_with_the_greatest_number_of_candies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<bool> result = KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
            Debug.Assert(result.SequenceEqual(new List<bool> { true, true, true, false, true }));

            result = KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
            Debug.Assert(result.SequenceEqual(new List<bool> { true, false, false, false, false }));

            result = KidsWithCandies(new int[] { 12, 1, 12 }, 10);
            Debug.Assert(result.SequenceEqual(new List<bool> { true, false, true }));
        }

        public static  IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var maxCandies = candies.Max();
            IList<bool> result = new List<bool>();
            foreach (var kidWithcandies in candies)
            {
                if(kidWithcandies + extraCandies >= maxCandies)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }
            return result;
        }
    }
}
