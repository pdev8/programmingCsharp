﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Polymorphism.Sealed
{
    class Child : Base
    {
        public override void Write() => Console.WriteLine("This is the child class.");
    }
}
