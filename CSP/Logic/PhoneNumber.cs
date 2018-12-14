using System;
using System.Linq;

namespace CSP.TeknowlogiAPIs
{
    public class PhoneNumber
    {
        public static void Run()
        {
            ////Console.WriteLine(GetDefaultPhoneNumber("7772221111"));

            var test1 = GetPhoneNumber("9496162630");
            Console.WriteLine($"Area code: {test1.AreaCode}");
            Console.WriteLine($"phoneNumber: {test1.Numbers}");
            Console.WriteLine($"Extension: {test1.Extension}");
            Console.WriteLine();

            var test2 = GetPhoneNumber("19496162630");
            Console.WriteLine($"Area code: {test2.AreaCode}");
            Console.WriteLine($"phoneNumber: {test2.Numbers}");
            Console.WriteLine($"Extension: {test2.Extension}");
            Console.WriteLine();

            var test3 = GetPhoneNumber("+19496162630");
            Console.WriteLine($"Area code: {test3.AreaCode}");
            Console.WriteLine($"phoneNumber: {test3.Numbers}");
            Console.WriteLine($"Extension: {test3.Extension}");
            Console.WriteLine();

            var test4 = GetPhoneNumber("+19496162630x123");
            Console.WriteLine($"Area code: {test4.AreaCode}");
            Console.WriteLine($"phoneNumber: {test4.Numbers}");
            Console.WriteLine($"Extension: {test4.Extension}");
            Console.WriteLine();


            var test5 = GetPhoneNumber("19496162630ext4");
            Console.WriteLine($"Area code: {test5.AreaCode}");
            Console.WriteLine($"phoneNumber: {test5.Numbers}");
            Console.WriteLine($"Extension: {test5.Extension}");
            Console.WriteLine();

            var test6 = GetPhoneNumber("19496162630ext10");
            Console.WriteLine($"Area code: {test6.AreaCode}");
            Console.WriteLine($"phoneNumber: {test6.Numbers}");
            Console.WriteLine($"Extension: {test6.Extension}");
            Console.WriteLine();
        }

        public static string GetDefaultPhoneNumber(string phone)
        {
            return $"{new string(phone.Take(3).ToArray())}-{new string(phone.Skip(3).Take(3).ToArray())}-{phone.Substring(6)}";
        }

        private static PhoneNumbersOnly GetPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return new PhoneNumbersOnly
                {
                    AreaCode = "555",
                    Numbers = "5555555",
                    Extension = string.Empty
                };
            }

            phoneNumber = new string(phoneNumber?.Where(char.IsDigit).ToArray());
            phoneNumber = phoneNumber.TrimStart('1');

            if (phoneNumber.Length >= 11)
            {
                return new PhoneNumbersOnly
                {
                    AreaCode = phoneNumber.Substring(0, 3),
                    Numbers = phoneNumber.Substring(3, 7),
                    Extension = phoneNumber.Substring(10)
                };
            }

            return new PhoneNumbersOnly
            {
                AreaCode = phoneNumber.Substring(0, 3),
                Numbers = phoneNumber.Substring(3, 7),
                Extension = string.Empty
            };
        }

        ////private static PhoneNumber GetPhoneNumber(string phoneNumber)
        ////{
        ////    if (phoneNumber != null && phoneNumber.Length > 9)
        ////    {
        ////        var numbers = string.Empty;
        ////        if (phoneNumber[0] == '+' && phoneNumber[1] == '1')
        ////        {
        ////            numbers = phoneNumber.Substring(2);
        ////        }

        ////        numbers = new string(phoneNumber.Where(char.IsDigit).ToArray());

        ////        if (numbers.Length == 10)
        ////        {
        ////            return new PhoneNumber
        ////            {
        ////                AreaCode = new string(numbers.TakeWhile(char.IsDigit).Take(3).ToArray()),
        ////                Numbers = new string(numbers.TakeWhile(char.IsDigit).Skip(3).ToArray()).Substring(3),
        ////                Extension = string.Empty
        ////            };
        ////        }

        ////        if (numbers.Length > 11)
        ////        {
        ////            return new PhoneNumber
        ////            {
        ////                AreaCode = new string(numbers.TakeWhile(char.IsDigit).Take(3).ToArray()),
        ////                Numbers = new string(numbers.TakeWhile(char.IsDigit).Skip(3).Take(7).ToArray()),
        ////                Extension = new string(numbers.Where(char.IsDigit).ToArray()).Substring(10)
        ////            };
        ////        }
        ////    }

        ////    return new PhoneNumber
        ////    {
        ////        AreaCode = "555",
        ////        Numbers = "5555555",
        ////        Extension = string.Empty
        ////    };
        ////}

        public class PhoneNumbersOnly
        {
            public string AreaCode { get; set; }

            public string Numbers { get; set; }

            public string Extension { get; set; }
        }
    }
}