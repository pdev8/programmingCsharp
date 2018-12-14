using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes
{
    public class S2P9
    {
        public static void Run()
        {
            Console.WriteLine("param Example:");
            var result1 = new Calculator().Add(new[] { 1, 2, 3, 4 });
            Console.WriteLine("new Calculator().Add(new[] " + "{ 1, 2, 3, 4 }): " + $"{result1}");
            var result2 = new Calculator().Add(1, 2, 3, 4);
            Console.WriteLine($"new Calculator().Add(1, 2, 3, 4): {result2}");

            Console.WriteLine("\nref Example:");
            int a = 1;
            var weirdo = new Weirdo();
            // Without the ref keyword, a would still equal 1 after the calculation
            weirdo.DoAWeirdThing(ref a);
            Console.WriteLine($"Value of 'a' after the calculation: {a}");

            Console.WriteLine("\nout Example:");
            int b;
            new MyClass().MyMethod(out b);
            Console.WriteLine($"Value of 'b' after out: {b}");

            // Example of the out modifier
            int number;
            // Different than the Parse() method, because TryParse() will not throw an exception
            bool result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at ({point.X}, {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at ({point.X}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }

    // params keyword
    internal class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }

    // ref keyword
    internal class Weirdo
    {
        // Will make the value type "a" into a ref type
        public void DoAWeirdThing(ref int a)
        {
            a += 2;
        }
    }

    // out keywork
    internal class MyClass
    {
        // out keyword will let the method return multiple values
        public void MyMethod(out int result)
        {
            result = 1;
        }
    }

    internal class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // This is more efficient than...
            if (newLocation.Equals(null))
                throw new ArgumentNullException(nameof(newLocation));

            Move(newLocation.X, newLocation.Y);

            // This is bad practice and a code smell
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }
}
