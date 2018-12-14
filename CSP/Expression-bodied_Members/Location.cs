using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Expression_bodied_Members
{
    class Location
    {
        private string locationName;

        public Location(string name) => locationName = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }
}
