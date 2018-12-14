using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Challenge.Structure
{
    class CarOwner
    {
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public int SpaceId { get; set; }
        public int SpaceLevel { get; set; }
        public SpaceType Status { get; set; }

        public CarOwner()
        {
            Name = "Test Dummy";
            LicensePlate = "7CSK518";
            Status = SpaceType.FrequentFlyer;
        }
    }
}
