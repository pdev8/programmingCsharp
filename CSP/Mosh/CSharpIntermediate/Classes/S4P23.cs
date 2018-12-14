using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes
{
    class S4P23
    {
        public static void Run()
        {
            object obj = new object();
            Car car1 = (Car) obj; // May throw an exception


            // as keyword
            // If the type cannot be cast, then the value is null
            Car car2 = obj as Car; // This is safer
            if (car2 != null) { }

            // is keyword
            if (obj is Car)
            {
                Car car = (Car) obj;
            }

            // -----------------------------------------

            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
        }
    }

    class Car
    {
        
    }

    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

    }

    class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}
