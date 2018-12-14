using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC01
    {
        public static int GetMaxProfit(int[] stockPricesYesterday)
        {
            if (stockPricesYesterday.Length < 2)
            {
                throw new ArgumentException("There must be more than 2 prices");
            }

            int lowestPrice = stockPricesYesterday[0];

            int maxProfit = stockPricesYesterday[1] - lowestPrice;

            for (int i = 0; i < stockPricesYesterday.Length; i++)
            {
                int currentPrice = stockPricesYesterday[i];

                int potentialProfit = currentPrice - lowestPrice;

                maxProfit = Math.Max(potentialProfit, maxProfit);

                lowestPrice = Math.Min(currentPrice, lowestPrice);
            }

            return maxProfit;
        }
    }
}
