using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndTestability
{
    public class Shipment : Order
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}
