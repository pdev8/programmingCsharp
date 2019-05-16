using System;
using System.IO;

namespace CSP.FileStream
{
    public class StreamReaderPractice
    {
        public static void Run()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (var streamReader = new StreamReader("C:\\Users\\ppauleee\\Documents\\Personal\\Test\\Jamaica.txt"))
                {
                    string line;

                    // Read and display lines from the file until
                    // the end of the file is reached.
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
