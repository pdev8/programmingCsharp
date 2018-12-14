using System;
using System.IO;

namespace CSP.AdventOCode
{
    public class Day3
    {
        public static void Run()
        {
            //var lines = new[]
            //{
            //    "#1 @ 1,3: 4x4",
            //    "#2 @ 3,1: 4x4",
            //    "#3 @ 5,5: 2x2"
            //};

            var lines = GetLinesFromText();

            var twoDimArray = GetDay3Part1(lines);

            // TODO: Need to figure out which claim does not overlap w/ other claims (there is only one)
            GetDay3Part2(twoDimArray);
        }

        private static string[] GetLinesFromText()
        {
            var path = @"C:\Users\ppauleee\Documents\Personal\AdventOCode\Dimensions3.txt";
            var lines = File.ReadAllLines(path);

            return lines;
        }

        private static string[,] GetDay3Part1(string[] lines)
        {
            var dimensions = FindLengthAndWidth(lines);

            return DrawFirstClaim(dimensions, lines);
        }

        private static Tuple<int, int> FindLengthAndWidth(string[] claims)
        {
            var greatestLength = 0;
            var greatestWidth = 0;

            foreach (var claim in claims)
            {
                var atSign = claim.IndexOf("@", StringComparison.OrdinalIgnoreCase);
                var colon = claim.IndexOf(":", StringComparison.OrdinalIgnoreCase);

                var coordinates = claim.Substring(atSign + 1, colon - atSign - 1).Trim().Split(',');
                var dimensions = claim.Substring(colon + 1).Trim().Split('x');

                if (greatestLength <= Convert.ToInt32(coordinates[0]) + Convert.ToInt32(dimensions[0]))
                {
                    greatestLength = Convert.ToInt32(coordinates[0]) + Convert.ToInt32(dimensions[0]);
                }

                if (greatestWidth <= Convert.ToInt32(coordinates[1]) + Convert.ToInt32(dimensions[1]))
                {
                    greatestWidth = Convert.ToInt32(coordinates[1]) + Convert.ToInt32(dimensions[1]);
                }
            }

            return new Tuple<int, int>(++greatestLength, ++greatestWidth);
        }

        private static string[,] DrawFirstClaim(Tuple<int, int> dimensions, string[] claims)
        {
            var twoDimArray = new string[dimensions.Item1, dimensions.Item2];

            for (var i = 0; i < dimensions.Item1; i++)
            {
                for (var j = 0; j < dimensions.Item2; j++)
                {
                    twoDimArray[i, j] = ".";
                }
            }

            foreach (var claim in claims)
            {
                var atSign = claim.IndexOf("@", StringComparison.OrdinalIgnoreCase);
                var colon = claim.IndexOf(":", StringComparison.OrdinalIgnoreCase);

                var number = claim.Substring(claim.IndexOf("#", StringComparison.OrdinalIgnoreCase) + 1, atSign - 1).Trim();
                var coordinates = claim.Substring(atSign + 1, colon - atSign - 1).Trim().Split(',');
                var size = claim.Substring(colon + 1).Trim().Split('x');

                var coordinatesAsInts = Array.ConvertAll(coordinates, Convert.ToInt32);
                var sizeAsInts = Array.ConvertAll(size, Convert.ToInt32);

                for (var i = 0; i < dimensions.Item1; i++)
                {
                    for (var j = 0; j < dimensions.Item2; j++)
                    {
                        if (i >= coordinatesAsInts[0] && i <= (coordinatesAsInts[0] + sizeAsInts[0] - 1) && j >= coordinatesAsInts[1] && j <= (coordinatesAsInts[1] + sizeAsInts[1] - 1))
                        {
                            var current = twoDimArray[j, i];
                            twoDimArray[j, i] = number;

                            if (current != "." && current != number)
                            {
                                twoDimArray[j, i] = "X";
                            }
                        }
                    }
                }
            }

            var numberOfXs = 0;
            for (var i = 0; i < dimensions.Item1; i++)
            {
                for (var j = 0; j < dimensions.Item2; j++)
                {
                    if (twoDimArray[i, j] == "X")
                    {
                        numberOfXs++;
                    }
                }
            }

            Console.WriteLine($"Number of squre inches: {numberOfXs}");

            ////for (var i = 0; i < dimensions.Item1; i++)
            ////{
            ////    for (var j = 0; j < dimensions.Item2; j++)
            ////    {
            ////        Console.Write(twoDimArray[i, j]);
            ////    }

            ////    Console.WriteLine();
            ////}

            return twoDimArray;
        }

        private static void GetDay3Part2(string[,] twoDimArray)
        {

        }
    }
}