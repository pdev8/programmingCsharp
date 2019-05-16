using System.IO;
using Unity.Interception.Utilities;

namespace CSP.FileStream
{
    public class StreamPractice
    {
        public static void Run()
        {
            ReadAndWrite();
        }

        public static void Weather()
        {
            var poem = new[]
            {
                "Whether the weather be fine",
                "Whether the weather be not",
                "Whether the weather be cold",
                "Whether the weather be hot",
                "We'll weather the weather",
                "Whether we like it or not"
            };

            using (var fileStream = new System.IO.FileStream("c:\\Users\\ppauleee\\Documents\\Personal\\Test\\Jamaica2.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    poem.ForEach(s => streamWriter.WriteLine(s));
                }
            }
        }

        public static void ReadAndWrite()
        {

        }
    }
}