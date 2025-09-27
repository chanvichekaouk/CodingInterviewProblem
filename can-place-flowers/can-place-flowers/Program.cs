using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace can_place_flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1);
            Debug.Assert(result.Equals(true));

            result = CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2);
            Debug.Assert(result.Equals(false));

            result = CanPlaceFlowers(new int[] { 0, 0, 1, 0, 0 }, 1);
            Debug.Assert(result.Equals(true));
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int plantedCount = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                    continue;

                bool isAdjacent = false;
                if (i - 1 >= 0)
                {
                    if (flowerbed[i - 1] == 1)
                        isAdjacent = true;
                }

                if(i + 1 < flowerbed.Length)
                {
                    if (flowerbed[i + 1] == 1)
                        isAdjacent = true;
                }

                if (!isAdjacent)
                {
                    flowerbed[i] = 1;
                    plantedCount++;
                }
            }
            return plantedCount >= n;
        }
    }
}
