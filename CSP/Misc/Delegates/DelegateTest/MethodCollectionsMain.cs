using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Delegates.DelegateTest
{
    class MethodCollectionsMain
    {
        public static void Run()
        {
            Action printText = MethodCollections.PrintText;
            Action<string> print = MethodCollections.Print;
            Action<int, int> printNumber = MethodCollections.PrintNumbers;

            Func<int, int, int> add1 = MethodCollections.Addition;
            Func<int, int, string> add2 = MethodCollections.DisplayAddition;
            Func<string, string, string> completeName = MethodCollections.ShowCompleteName;
            Func<int> random = MethodCollections.ShowNumber;

            Console.WriteLine("\n**************** Action<> Delegate Methods ****************\n");
            printText(); // Parameter: 0, Returns: nothing
            print("Paul"); // Parameter: 1, Returns: nothing
            printNumber(1, 10); // Parameter: 2, Returns: nothing
            Console.WriteLine();

            Console.WriteLine("\n**************** Func<> Delegate Methods ****************\n");
            int addition = add1(7, 13); // Parameter: 2, Returns: int
            string addition2 = add2(5, 8); // Parameter: 2, Returns: string
            string name = completeName("Paul", "Lee"); // Parameter: 2, Returns: string
            int randomNumbers = random(); // Parameter: 0, Returns: int

            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine(addition2);
            Console.WriteLine(name);
            Console.WriteLine($"Random number is {randomNumbers}");
        }
    }
}
