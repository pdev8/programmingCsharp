using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CSP.SOLID
{
    public class SingleResponsibilityPrinciple
    {
        public static void Run()
        {
            var journal = new Journal();
            journal.AddEntry("I cried today.");
            journal.AddEntry("I ate a bug.");
            Console.WriteLine(journal);

            var p = new Persistence();
            var fileName = @"C:\Users\ppauleee\Documents\Personal\Test";

            p.SaveToFile(journal, fileName);
            Process.Start(fileName);
        }
    }

    // Everything inside the Journal should be specific to the Journal and not generic methods
    // that have multiple use cases
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");

            return count; // memento pattern
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // Adding too much responsibility
        // ----------------------------------------------------------
        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }

        public static Journal Load(string fileName)
        {
            return new Journal();
        }
    }

    // Can persist many different things, including journals

    // There is now a separation of concerns
    // -- The journal is concerned w/ keeping a bunch of entries and the persistent class is concerned w/
    // -- saving whatever object that's being fed whether it's a journal or something else
    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }
    }
}
