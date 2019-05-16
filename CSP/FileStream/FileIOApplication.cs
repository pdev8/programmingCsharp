using System;
using System.IO;

namespace CSP.FileStream
{
    public class FileIOApplication
    {
        public static void Run()
        {
            var f = new System.IO.FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite);

            for (var i = 1; i <= 20; i++)
            {
                f.WriteByte((byte)i);
            }

            f.Position = 0;

            for (var i = 0; i <= 20; i++)
            {
                Console.Write($"{f.ReadByte()} ");
            }

            f.Close();
        }
    }
}