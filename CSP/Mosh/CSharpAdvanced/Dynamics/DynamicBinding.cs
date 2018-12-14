using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.Dynamics
{
    class DynamicBinding
    {
        public static void Run()
        {
            object obj = "Paul";
            // obj.GetHashCode();

            // Using reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            // Using dynamic w/o using reflection
            // dynamic - Represents an object whose operations will be resolved at runtime

            // Imagine that we had an Excel object and it had some methods or properties
            dynamic excelObject = "Excel Object";
            // At runtime, the object should have a method, Optimize()
            excelObject.Optimize();


            // This is not possible w/ static types like int, object, string, etc (we would
            // get an exception)
            dynamic name = "Paul"; // Since it's dynamic, during runtime type, this would be a string
            name = 10;

            // var will turn to dynamic
            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            // Casting
            int i = 5;
            dynamic d = i; // At runtime, dynamic will be an int
            long l = d; // A long is big enough to hold an int

            // When converting from dynamic to static types, if the runtime type of the dynamic
            // object is implicitly convertible to the target type, it does not need to be cast
        }
    }
}
