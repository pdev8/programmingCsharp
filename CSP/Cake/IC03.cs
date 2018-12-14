using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC03
    {
        public static void Run()
        {
            Console.WriteLine($"The highest product in the array is: {HighestProductOf3(new[] { -10, -10, 1, 3, 2 })}");
        }

        // We need to keep track of the lowest number and highest number. If the current number times the current
        // highest -- or the current lowest, if current is negative -- is greater than the current highestProductOf2,
        // we have a new highestProdutOf2. Same for lowestProductOf2.
        static int HighestProductOf3(int[] arrayOfInts)
        {
            if (arrayOfInts.Length < 3)
            {
                throw new ArgumentException("Less than 3 items!");
            }

            int highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            int lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);

            int highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            int lowestProductOf2 = arrayOfInts[0] * arrayOfInts[1];

            int highestProductOf3 = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            for (int i = 2; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];

                highestProductOf3 = Math.Max(Math.Max(highestProductOf3, current * highestProductOf2), current * lowestProductOf2);

                highestProductOf2 = Math.Max(Math.Max(highestProductOf2, current * highest), current * lowest);

                lowestProductOf2 = Math.Min(Math.Min(lowestProductOf2, current * highest), current * lowest);

                highest = Math.Max(highest, current);

                lowest = Math.Min(lowest, current);
            }

            return highestProductOf3;
        }
    }
}
