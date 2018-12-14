using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndPolymorphism
{
    interface INotificationChannel
    {
        void Send(Message message);
    }
}
