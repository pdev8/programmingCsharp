using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSP.Challenge.Structure;

namespace CSP.Algorithms
{
    public class PyramidSteps
    {
        /// <summary>
        ///
        /// --- Directions
        /// Write a function that accepts a positive number N. The function should console
        /// log a pyramid shape w/ N levels using the # character. Make sure the pyramid has
        /// spaces on both the left *and* right hand sides.
        /// --- Examples
        ///     pyramid(1)
        ///         '#'
        ///     pyramid(2)
        ///         ' # '
        ///         '###'
        ///     pyramid(3)
        ///         '  #  '
        ///         ' ### '
        ///         '#####'
        ///     pyramid(4)
        ///         '   #   '
        ///         '  ###  '
        ///         ' ##### '
        ///         '#######'
        /// 
        /// </summary>
        public static void Run()
        {
            BuildPyramidRecursively(3);
        }

        public static void BuildPyramid(int number)
        {
            decimal midpoint = Math.Floor((decimal)(((2 * number) - 1) / 2));
            for (int i = 0 ; i < number; i++)
            {
                for (var j = 0; j < number + (number - 1); j++)
                {
                    if (midpoint - i <= j && midpoint + i >= j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }

                Console.WriteLine();
            }
        }

        // TODO: Need to figure this out...
        public static void BuildPyramidRecursively(int number, int row = 0, string level = "")
        {
            if (row == number)
            {
                return;
            }

            if (level.Length == 2 * number - 1)
            {
                Console.Write(level);

                BuildPyramidRecursively(number, row + 1);
            }

            var midpoint = Math.Floor((decimal)(2 * number - 1) / 2);

            var add = string.Empty;
            if (midpoint - row <= level.Length && midpoint + row >= level.Length)
            {
                add = "+";
            }
            else
            {
                add = "";
            }

            BuildPyramidRecursively(number, row, level + add);
        }
    }
}
