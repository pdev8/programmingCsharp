using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    public class SampleEx
    {
        public static void Run()
        {
            var message = new[]
            {
                'c', 'a', 'k', 'e', ' ',
                'p', 'o', 'u', 'n', 'd', ' ',
                's', 't', 'e', 'a', 'l'
            };

            ReverseWords(message);

            Console.WriteLine(new string(message));
        }

        private static void ReverseWords(char[] message)
        {
            ReverseCharacters(message, 0, message.Length - 1);

            var currentWordStartIndex = 0;
            for (var i = 0; i <= message.Length; i++)
            {
                if (i == message.Length || message[i] == ' ')
                {
                    ReverseCharacters(message, currentWordStartIndex, i - 1);
                    currentWordStartIndex = i + 1;
                }
            }
        }

        private static void ReverseCharacters(char[] message, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                var current = message[leftIndex];

                message[leftIndex] = message[rightIndex];
                message[rightIndex] = current;

                leftIndex++;
                rightIndex--;
            }
        }
    }
}