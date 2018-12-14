using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes.InterfacesAndTestability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
