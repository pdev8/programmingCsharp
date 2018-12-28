using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Given an array and chunk size, divide the array into many subarrays
    /// where each subarray is of length size
    /// --- Examples
    /// chunk([1, 2, 3, 4], 2) --> [[1, 2], [3, 4]]
    /// chunk([1, 2, 3, 4, 5], 2) --> [[1, 2], [3, 4], [5]]
    /// chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[1, 2, 3], [4, 5, 6], [7, 8]]
    /// chunk([1, 2, 3, 4, 5], 4) --> [[1, 2, 3, 4], [5]]
    /// chunk([1, 2, 3, 4, 5], 10) --> [[1, 2, 3, 4, 5]]
    /// </summary>
    public class ArrayChunk
    {
        public static void Run()
        {
            var chunk = Chunk3(new[] { 1, 2, 3, 4 }, 2);
            var chunk2 = Chunk3(new[] { 1, 2, 3, 4, 5 }, 2);
            var chunk3 = Chunk3(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3);
            var chunk4 = Chunk3(new[] {1, 2, 3, 4, 5}, 4);
            var chunk5 = Chunk3(new[] {1, 2, 3, 4, 5}, 10);
        }

        public static List<List<int>> Chunk(int[] array, int chunkSize)
        {
            var counter = 0;
            var index = 0;
            var parentList = new List<List<int>>();
            while (counter < array.Length)
            {
                var innerCounter = 0;
                var childList = new List<int>();
                while (innerCounter < chunkSize)
                {
                    if (index < array.Length)
                    {
                        childList.Add(array[index]);
                    }

                    index++;
                    innerCounter++;
                }
                parentList.Add(childList);

                counter += chunkSize;
            }

            return parentList;
        }

        public static List<List<int>> Chunk2(int[] array, int chunkSize)
        {
            var parent = new List<List<int>>();

            List<int> last = null;
            foreach (var num in array)
            {
                if (last == null || last.Count == chunkSize)
                {
                    parent.Add(new List<int>
                    {
                        num
                    });
                }
                else
                {
                    last.Add(num);
                }

                last = parent[parent.Count - 1];
            }

            return parent;
        }

        public static List<List<int>> Chunk3(int[] array, int chunkSize)
        {
            var parent = new List<List<int>>();

            var index = 0;

            while (index < array.Length)
            {
                parent.Add(array.Skip(index).Take(chunkSize).ToList());

                index += chunkSize;
            }

            return parent;
        }
    }
}