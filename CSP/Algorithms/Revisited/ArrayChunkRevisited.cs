using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms.Revisited
{
    public class ArrayChunkRevisited
    {
        public static void Run()
        {
            var array = GetArrayChunk(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
        }

        private static List<List<int>> GetArrayChunk(int[] array, int chunkSize)
        {
            var parent = new List<List<int>>();

            var counter = 0;
            while (counter < array.Length)
            {
                parent.Add(array.Skip(counter).Take(chunkSize).ToList());

                counter += chunkSize;
            }


            return parent;
        }
    }
}