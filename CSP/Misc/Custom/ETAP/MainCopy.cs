using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.ETAP
{
    class MainCopy
    {
        public static void Run()
        {
            CustomList test = new CustomList();
            bool open = true;

            while (open)
            {
                bool run = true;

                while (run)
                {
                    Console.WriteLine("What operation would you like to run on your array? (add, remove, clear, sort)");
                    string operation = Console.ReadLine().ToLower();
                    // Add
                    if (operation == "add")
                    {
                        Console.WriteLine("\nHow many values would you like to insert?");
                        int numberOfTimes = Convert.ToInt32(Console.ReadLine());

                        int token = 1;

                        while (token <= numberOfTimes)
                        {
                            Console.WriteLine($"What is the value for #{token}?");
                            test.Add(Convert.ToInt32(Console.ReadLine()));
                            token++;
                        }
                        Console.WriteLine();
                    }

                    // Remove
                    //Console.WriteLine();
                    if (operation == "remove")
                    {
                        Console.WriteLine("\nWhat value would you like to remove?");

                        int number = Convert.ToInt32(Console.ReadLine());

                        test.Remove(number);
                    }

                    if (operation == "clear")
                    {
                        Console.WriteLine("Are you sure you want to clear the array?");

                        if (Console.ReadLine().ToLower() == "n")
                        {
                            continue;
                        }
                        else
                        {
                            test.Clear();
                        }
                    }

                    if (operation == "sort")
                    {
                        test.Sort();
                    }
   
                    // ------------------------------------------------
                    Console.WriteLine("Would you like to go on? y/n");
                    if (Console.ReadLine().ToLower() != "y")
                    {
                        run = false;
                    }
                }

                Console.Write("\n[ ");
                for (int i = 0; i < test.Content.Length; i++)
                {
                    Console.Write(test.Content[i]);
                    if (i != test.Content.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(" ]");

                Console.WriteLine("Would you like to go on? y/n");

                if (Console.ReadLine().ToLower() != "y")
                {
                    open = false;
                }
            }
        }
    }
}
