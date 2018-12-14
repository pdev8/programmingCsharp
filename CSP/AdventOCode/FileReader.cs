using System.IO;

namespace CSP.AdventOCode
{
    public class FileReader : IFileReader
    {
        public string[] ReadLinesFromTextFile(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}