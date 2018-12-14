using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP
{
    class MyClass
    {
        public readonly string Name;
        private int intVal;

        public int Val
        {
            get => intVal;
            set
            {
                if (value >= 0 && value <= 10)
                    intVal = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10.");
                }
            }
        }

        public override string ToString() => "Name: " + Name + "\nVal: " + Val;

        private MyClass() : this("Default Name") { }

        private int myDoubledInt;

        public int MyDoubledInt
        {
            get => myDoubledInt;
            set => myDoubledInt = value;
        }

        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
            //myDoubledInt = 0;
        }


        public int myDoubledIntProp => (myDoubledInt * 2);
    }
}
