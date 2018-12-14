using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndPolymorphism
{
    class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}
