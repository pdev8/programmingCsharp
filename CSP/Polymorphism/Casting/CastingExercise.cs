using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Polymorphism.Casting
{
    public class CastingExercise
    {
        public static void Run()
        {
            Console.WriteLine(int.TryParse("123x3", out int num) ? num : 3);
            Console.WriteLine(int.Parse("123x3"));
        }
    }
}
