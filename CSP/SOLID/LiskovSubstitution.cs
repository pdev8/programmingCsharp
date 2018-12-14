using System;

namespace CSP.SOLID
{
    public class LiskovSubstitution
    {
        public class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle()
            {
            }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public override string ToString()
            {
                return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
            }
        }

        public class Square : Rectangle
        {
            public new int Width
            {
                set => base.Height = base.Width = value;
            }

            public new int Height
            {
                set => base.Height = base.Width = value;
            }
        }

        public static int Area(Rectangle r) => r.Width * r.Height;

        public static void Run()
        {
            var rc = new Rectangle();
            Console.WriteLine($"{rc} has area {Area(rc)}");

            var sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");

            Rectangle rqsq = new Square();
            rqsq.Width = 4;
            Console.WriteLine($"{rqsq} has area {Area(rqsq)}");
        }
    }
}