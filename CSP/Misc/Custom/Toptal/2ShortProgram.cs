using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _2ShortProgram
    {
        //private static String location;
        //private static DateTime time;

        //static void Run()
        //{
            // What is the outpus of the short program?
        //    Console.WriteLine(location == null ? "location is null" : location);
        //    Console.WriteLine(time == null ? "time is null" : time.ToString());
        //}

        // Paul's Explanation
        // 1st output: "location is null"
        // 2nd output: 1/1/0001 12:00:00 AM
        // Value types can not be nullable unless it is declared as a nullable type
        // Ref type are made null if not initialized

        // Toptal's Explanation
        // Although both variables are unitialized, String is a reference type and DateTime
        // is a value type. As a value type, an uninitialiized DateTime variable is set to
        // a default value of midnight of 1/1/1
    }
}
