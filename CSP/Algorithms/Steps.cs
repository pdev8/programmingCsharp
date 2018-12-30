using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Write a function that accepts a positive number N. The function should
    /// console log a step shape w/ N levels using the character. Make sure the
    /// step has spaces on the right side!
    /// --- Examples
    ///     steps(2)
    ///         '# '
    ///         '##'
    ///     steps(3)
    ///         '#  '
    ///         '## '
    ///         '###'
    /// 
    /// </summary>
    public class Steps
    {
        public static void Run()
        {
            PrintSteps2(5);
        }

        private static void PrintSteps(int numOfSteps)
        {
            for (var i = 0; i < numOfSteps; i++)
            {
                var counter = 0;
                var row = new StringBuilder();
                while (counter < numOfSteps - i)
                {
                    row.Append(' ');
                    counter++;
                }

                counter = 0;
                while (counter <= i)
                {
                    row.Append('#');
                    counter++;
                }

                Console.WriteLine(row.ToString().Reverse().ToArray());
            }
        }

        private static void PrintSteps2(int numOfSteps)
        {
            for (var i = 0; i < numOfSteps; i++)
            {
                for (var j = 0; j < numOfSteps; j++)
                {
                    Console.Write(j <= i ? "#" : "O");
                }

                Console.WriteLine();
            }
        }

        // TODO: Need to figure this recursive solution
        private static void PrintSteps3(int numOfSteps, int row = 0, string stair = "")
        {
            if (numOfSteps == row)
            {
                return;
            }

            if (numOfSteps == stair.Length)
            {
                Console.WriteLine(stair);
                PrintSteps3(numOfSteps, ++row);
            }

            if (stair.Length <= row)
            {
                stair += "#";
            }
            else
            {
                stair += ' ';
            }

            PrintSteps3(numOfSteps, row, stair);
        }
    }
}