using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndTestability
{
    public class OrderMain
    {
        public static void Run()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order() {DatePlaced = DateTime.Now, TotalPrice = 100f};
            orderProcessor.Process(order);
        }
    }
}
