using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSP.PluralSight.CollectionsGenerics.Generics.GenericMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPTests.PluralSight.CollectionsGenerics.Generics.GenericMethod
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var expected = 42;

            // Act
            var actual = repository.RetrieveValue<int>("Select...", 42);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}