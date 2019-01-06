////using System;
////using System.Collections;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using Twilio.Rest.Preview.Understand.Assistant.FieldType;

////namespace CSP.Algorithms
////{
////    /// <summary>
////    ///
////    /// --- Directions
////    /// Write a function that accepts an integer N and returns a
////    /// NxN spiral matrix.
////    /// --- Examples
////    ///     matrix(2)
////    ///         [[1, 2],
////    ///          [4, 3]]
////    ///     matrix(3)
////    ///         [[1, 2, 3],
////    ///          [8, 9, 4],
////    ///          [7, 6, 5]]
////    ///     matrix(4)
////    ///         [[ 1,  2,  3, 4],
////    ///          [12, 13, 14, 5],
////    ///          [11, 16, 15, 6],
////    ///          [10,  9,  8, 7]]
////    /// 
////    /// </summary>
////    public class MatrixSprials
////    {
////        public static void Run()
////        {
////            BuildMatrix(3);
////        }

////        private static void BuildMatrix(int number)
////        {
////            var matrix = new ArrayList<ArrayList<int>>();

////            matrix.ForEach(s => s.ForEach(r => r = 0));

////            var sub = new List<int>();
////            for (var i = 0; i < number; i++)
////            {
////                sub[2] = 4;
////                matrix.Add(sub);
////            }
////        }
////    }
////}