using System;

namespace CSP.PluralSight.Arrays
{
    class M03P10
    {
        public static void Run()
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            MakeDaysPlural(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }

        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                // Strings are immutable, so you can't modify the individual strings. This line
                // is creating a new string for each day and replacing each element of the array
                // w/ a reference to the new string
                daysOfWeek[i] += 's';
            }

            // **************************************************************
            // This is the translation that happens if we used a foreach loop
            // NOTE: foreach is readonly!
            /*
             * foreach (string day in daysOfWeek)
             * {
             *      Only changes the copy and not the actual array element
             *      day = day + 's';
             * }
             */
            // --------Translates to-------->>>>
            /*
             * for (int i = 0; i < daysOfWeek.Length; i++)
             * {
             *      string day = daysOfWeek[i];
             *      day += 's';
             * }
             */
        }
    }
}
