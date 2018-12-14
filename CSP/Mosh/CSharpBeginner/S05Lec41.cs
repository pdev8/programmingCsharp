using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpBeginner
{
    public static class S05Lec41
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        public static void Run()
        {
            Season season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion!");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
