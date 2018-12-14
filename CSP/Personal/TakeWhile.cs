using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSP.Personal
{
    public static class TakeWhile
    {
        public static void Run()
        {
            string testString = "1234";

            var primaryNumber = GetNumbers(testString).Item1;

            var secondaryNumber = GetNumbers(testString).Item2;

            Console.WriteLine($"{primaryNumber} {secondaryNumber}");

            ////var stringLength = "123456789876543212345678909876543212";
            ////Console.WriteLine(stringLength.Length);
            ////Console.WriteLine(stringLength.Substring(0, 35).Length);
            ///
            var time = SetPickupStartTime(DateTime.Now.AddMinutes(31));
            Console.WriteLine(time);

            Console.WriteLine(DateTime.Now.ToUtcFromLocal(TimeZoneInfo.Utc));

            Console.WriteLine("532.1511.2351".ParsePhone());
        }

        public static Tuple<string, string> GetNumbers(string testString)
        {
            ////var primaryNMFCNumber = new string(testString.SkipWhile(s => !char.IsDigit(s)).TakeWhile(char.IsDigit).Take(5).ToArray());
            ///
            var primaryNMFCNumber = new string(testString.Where(char.IsDigit).Take(5).ToArray());

            var secondaryNMFCNumber = new string(testString.Where(char.IsDigit).Skip(5).TakeWhile(char.IsDigit).ToArray());

            return new Tuple<string, string>(primaryNMFCNumber, secondaryNMFCNumber);
        }

        public static DateTime SetPickupStartTime(DateTime pickupReadyDateTime)
        {
            var currentTime = DateTime.Now;
            var span = currentTime - pickupReadyDateTime;

            if (span.Ticks < 0 && Math.Abs(span.Minutes) < 30 || pickupReadyDateTime < currentTime)
            {
                pickupReadyDateTime = currentTime.AddHours(1.5);
            }

            return pickupReadyDateTime;
        }

        public static string ParsePhone(this string value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return string.Empty;
                }

                var result = Regex.Replace(value.ToString().ToLower(), @"[^\dx\+]", string.Empty);

                if (string.IsNullOrWhiteSpace(result))
                {
                    return string.Empty;
                }

                var extIndex = result.IndexOf("x");

                result = result.Substring(0, extIndex + 1) + result.Substring(extIndex + 1).Replace("x", string.Empty);
                result = result.Substring(0, 1) + result.Substring(1).Replace("+", string.Empty);

                if (result.IndexOf('+') != 0)
                {
                    if (result.IndexOf('1') != 0)
                    {
                        result = "1" + result;
                    }

                    result = "+" + result;
                }

                return result;
            }
            catch
            {
                throw new FormatException(string.Format("Phone / fax number is not in a valid format please check submitted phone number: {0}", value.ToString()));
            }
        }

        public static DateTime ToUtcFromLocal(this DateTime dateTime, TimeZoneInfo localTimeZone)
        {
            if (dateTime.Kind == DateTimeKind.Utc || localTimeZone == null)
            {
                return dateTime;
            }

            dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
            return TimeZoneInfo.ConvertTimeToUtc(dateTime, localTimeZone);
        }

        public static DateTime ToLocalFromUtc(this DateTime dateTime, TimeZoneInfo localTimeZone)
        {
            if (dateTime.Kind != DateTimeKind.Utc || localTimeZone == null)
            {
                return dateTime;
            }

            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, localTimeZone);
        }

        public static DateTime AddBusinessDays(this DateTime current, int days)
        {
            var sign = Math.Sign(days);
            var unsignedDays = Math.Abs(days);

            for (var i = 0; i < unsignedDays; i++)
            {
                do
                {
                    current = current.AddDays(sign);
                }
                while (current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday);
            }

            return current;
        }
    }
}