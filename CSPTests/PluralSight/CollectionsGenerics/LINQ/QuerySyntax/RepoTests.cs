using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSP.PluralSight.CollectionsGenerics.LINQ.QuerySyntax;
using System;
using System.Collections.Generic;
using System.Linq;
using CSP.PluralSight.CollectionsGenerics.Generics.GenericMethod;

namespace CSPTests.PluralSight.CollectionsGenerics.LINQ.QuerySyntax
{
    [TestClass()]
    public class RepoTests
    {
        [TestMethod()]
        public void RetrieveAllTest()
        {
            // Arrange
            var repository = new Repo();
            var expected = new List<Vendor>()
            {
                {
                    new Vendor() {VendorId = 22, CompanyName = "Amalgamated Toys", Email = "a@abc.com"}
                },
                {
                    new Vendor() {VendorId = 28, CompanyName = "Toy Blocks Inc", Email = "blocks@abc.com"}
                },
                {
                    new Vendor() {VendorId = 35, CompanyName = "Car Toys", Email = "car@abc.com"}
                },
                {
                    new Vendor() {VendorId = 42, CompanyName = "Toys for Fun", Email = "fun@abc.com"}
                }
            };

            // Act
            var vendors = repository.RetrieveAll();

            //var vendorQuery = from v in vendors
            //    where v.CompanyName.Contains("Toy")
            //    orderby v.CompanyName
            //    select v;

            var vendorQuery = vendors.Where(v => v.CompanyName.Contains("Toy")).OrderBy(v => v.CompanyName);

            // Assert
            //CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }

        private bool FilterCompanies(Vendor v) => v.CompanyName.Contains("Toy");

        private string OrderCompaniesByName(Vendor v) => v.CompanyName;
    }
}