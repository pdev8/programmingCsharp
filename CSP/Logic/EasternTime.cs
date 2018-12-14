using System;

namespace CSP.TeknowlogiAPIs
{
    public class EasternTime
    {
        public static void Run()
        {
            Console.WriteLine(SetTimeToEst(DateTime.Parse("16:00")));
        }

        private static string SetTimeToEst(DateTime? timeToConvert)
        {
            if (timeToConvert == null)
            {
                return "1600";
            }

            var timeUtc = timeToConvert.GetValueOrDefault().ToUniversalTime();
            var easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);

            return easternTime.ToString("HHmm");
        }
    }
}