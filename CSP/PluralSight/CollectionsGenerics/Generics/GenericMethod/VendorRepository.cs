using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CollectionsGenerics.Generics.GenericMethod
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId"></param>
        /// <returns>A vendor</returns>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Temporary hard coded values to return
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }

            return vendor;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            // Call the database to retrieve the value
            // If no value is returned, return the default value
            T value = defaultValue;

            return value;
        }

        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>()
                {
                    new Vendor(){VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"},
                    new Vendor(){VendorId = 2, CompanyName = "XYZ Inc", Email ="xyz@xyz.com"}
                };
            }
            //Console.WriteLine(vendors);

            return vendors;
        }
    }
}
