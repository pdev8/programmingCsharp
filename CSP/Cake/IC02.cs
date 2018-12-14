using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC02
    {
        public static void Run()
        {
            foreach (int product in GetProductsOfAllIntsExceptAtIndex(new[] { 1, 7, 3, 4 }))
            {
                Console.WriteLine(product);
            }
        }

        static int[] GetProductsOfAllIntsExceptAtIndex(int[] arrayOfInts)
        {
            if (arrayOfInts.Length < 2)
            {
                throw new ArgumentException("Number of elements must be greater than 2");
            }

            int[] productArray = new int[arrayOfInts.Length];

            int productSoFar = 1;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                productArray[i] = productSoFar;
                productSoFar *= arrayOfInts[i];
            }

            productSoFar = 1;

            for (int i = arrayOfInts.Length - 1; i >= 0; i--)
            {
                productArray[i] *= productSoFar;
                productSoFar *= arrayOfInts[i];
            }

            return productArray;
        }
    }
}
