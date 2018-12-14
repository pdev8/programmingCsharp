using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.TeknowlogiAPIs
{
    public enum AssociationEnum
    {
        Shipper,
        Consignee,
        ThirdParty
    }

    public class EnumParsing
    {
        public static void Run()
        {
            var thirdParty = (AssociationEnum) Enum.Parse(typeof(AssociationEnum), "ThirdParty", true);
            Console.WriteLine(thirdParty);
        }
    }
}
