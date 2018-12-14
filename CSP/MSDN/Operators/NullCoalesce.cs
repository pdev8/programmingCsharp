using System;

namespace CSP.MSDN.Operators
{
    public class NullCoalesce
    {
        static int? GetNullableInt() => null;

        static string GetStringValue() => null;

        static int Add(int a, int b, int? c = null) => a + b + (c ?? 0);

        public static void Run()
        {
            int? x = null;

            // Set y to the value of x if x is NOT null; otherwise,
            // if x == null, set y to -1.
            // This is equivalent to:
            // int y = (x != null) ? x : -1;
            int y = x ?? -1;

            int i = GetNullableInt() ?? default(int);

            // Assign i to return value of the method if the method's
            string s = GetStringValue();

            Console.WriteLine(s ?? "Unspecified");

            Console.WriteLine(Add(1, 2, 3));
        }
    }
}
