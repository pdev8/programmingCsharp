using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSP.PluralSight.CollectionsGenerics.Generics.GenericMethod;

namespace CSP.PluralSight.CollectionsGenerics.LINQ.QuerySyntax
{
    public class Repo
    {
        public IEnumerable<Vendor> RetrieveAll()
        {
            var vendors = new List<Vendor>()
            {
                {
                    new Vendor() {VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"}
                },
                {
                    new Vendor() {VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"}
                },
                {
                    new Vendor() {VendorId = 12, CompanyName = "EFG Ltd", Email = "efg@efg.com"}
                },
                {
                    new Vendor() {VendorId = 17, CompanyName = "HIJ AG", Email = "hij@hij.com"}
                },
                {
                    new Vendor() {VendorId = 22, CompanyName = "Amalgamated Toys", Email = "a@abc.com"}
                },
                {
                    new Vendor() {VendorId = 28, CompanyName = "Toy Blocks Inc", Email = "blocks@abc.com"}
                },
                {
                    new Vendor() {VendorId = 31, CompanyName = "Home Products Inc", Email = "home@abc.com"}
                },
                {
                    new Vendor() {VendorId = 35, CompanyName = "Car Toys", Email = "car@abc.com"}
                },
                {
                    new Vendor() {VendorId = 42, CompanyName = "Toys for Fun", Email = "fun@abc.com"}
                }
            };
            return vendors;
        }
    }
}
