using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndTestability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get => Shipment != null;
        }
    }
}
