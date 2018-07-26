using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApp.core;
using ProductApp.Infrastructure;
using System.Linq;

namespace ProductApp.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repository;

          [TestInitialize]
        public void TestSetup()
        {
            ProductInitializeDB dB = new ProductInitializeDB();
            System.Data.Entity.Database.SetInitializer(dB);
            Repository = new ProductRepository();
        }

        [TestMethod]
        public void IsRepositoryInatializeWithValidNumberOfData()
        {
            var result = Repository.GetProducts();
            Assert.IsNotNull(result);

            var numberOfRecords = result.ToList().Count();

            Assert.AreEqual(2, numberOfRecords);
        }
        [TestMethod]
        public void IsRepositoryAddsProduct()
        {
            Product product = new Product()
            {
                Id = 3,
                Name = "sugar",
                inStock = true,
                Price = 50
            };
            Repository.Add(product);

            var numberOfRecords = Repository.GetProducts().ToList().Count;

            Assert.AreEqual(3, numberOfRecords);
        }
    }
}
