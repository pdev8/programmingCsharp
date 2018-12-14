using System;

namespace CSP.Mosh.CSharpBeginner
{
    public static class S05Lec47
    {
        public static void Run()
        {
            //Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next());    
            //}
            
            // 97 is a number that represents the lowercase letter 'a' (ASCII - American Standard Code for Information Interchange)
            //Console.WriteLine((int)'a');

            Random random = new Random();

            const int passwordLength = 10;

            char[] buffer = new char[passwordLength];

            for (int j = 0; j < passwordLength; j++)
            {
                // This code is confusing to anyone using this code
                //Console.Write((char)random.Next(97, 122));

                //Console.Write((char)('a' + random.Next(0, 26)));

                buffer[j] = (char) ('a' + random.Next(0, 26));

                string password = new string(buffer);
                Console.WriteLine(password);

                //if (j != 9)
                //    Console.Write(", ");
            }
            //string randomWord = String.Join("", buffer);
            //Console.WriteLine(randomWord);
        }
    }
}
