using System;

namespace CSP.TeknowlogiAPIs
{
    public class TimeLogic
    {
        public static void Run()
        {
            ////Console.WriteLine($"Time changed from 1:00 to {RoundDateTime2(new DateTime(2018, 10, 24, 1, 00, 0))}");
            ////Console.WriteLine($"Time changed from 1:27 to {RoundDateTime2(new DateTime(2018, 10, 24, 1, 27, 0))}");
            ////Console.WriteLine($"Time changed from 1:48 to {RoundDateTime2(new DateTime(2018, 10, 24, 1, 48, 0))}");
            ////Console.WriteLine($"Time changed from 2:01 to {RoundDateTime2(new DateTime(2018, 10, 24, 2, 01, 0))}");
            
            Console.WriteLine(Convert.ToInt32(DateTime.Parse("18:00").Hour) <= 18 && Convert.ToInt32(DateTime.Parse("18:00").Minute) < 1 ? GetHourValue(DateTime.Parse("18:01")) : 6);
        }

        private static DateTime RoundDateTime(DateTime dateTime)
        {
            var minute = dateTime.Minute;

            if (minute > 0 && minute < 15)
            {
                dateTime = dateTime.AddMinutes(15 - minute);
            }
            else if (minute > 15 && minute < 30)
            {
                dateTime = dateTime.AddMinutes(30 - minute);
            }
            else if (minute > 30 && minute < 45)
            {
                dateTime = dateTime.AddMinutes(45 - minute);
            }
            else if (minute > 45 && minute < 60)
            {
                dateTime = dateTime.AddMinutes(60 - minute);
            }

            return dateTime;
        }

        private static DateTime RoundDateTime2(DateTime dateTime)
        {
            var minute = dateTime.Minute;

            switch (minute)
            {
                case var min when (min > 0 && min < 15):
                    return dateTime.AddMinutes(15 - min);
                case var min when (min > 15 && min < 30):
                    return dateTime.AddMinutes(30 - min);
                case var min when (min > 30 && min < 45):
                    return dateTime.AddMinutes(45 - min);
                case var min when (min > 45 && min < 60):
                    return dateTime.AddMinutes(60 - min);
                default:
                    return dateTime;
            }
        }

        private static int GetHourValue(DateTime time)
        {
            return 18;
        }
    }
}