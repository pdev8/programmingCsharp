using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes
{
    class S4P21
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    class GoldCustomer : S4P21
    {
        public void OfferVoucher()
        {
            this.Promote();
        }
    }

    class S4P21Main
    {
        public static void Run()
        {
            var customer = new S4P21();
            customer.Promote();
        }
    }
}
