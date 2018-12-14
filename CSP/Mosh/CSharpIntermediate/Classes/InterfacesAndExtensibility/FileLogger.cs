using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndExtensibility
{
    enum MessageType { Error, Info }

    // OPEN CLOSED PRINCIPLE
    // This class should be closed for modification, but open for extension
    class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, MessageType.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, MessageType.Info);
        }

        private void Log(string message, MessageType type)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(type.ToString().ToUpper() + ": " + message);
            }
        }
    }
}
