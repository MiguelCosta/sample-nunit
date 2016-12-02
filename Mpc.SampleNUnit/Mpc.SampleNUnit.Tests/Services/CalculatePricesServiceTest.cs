using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mpc.SampleNUnit.Models;
using Mpc.SampleNUnit.Services;

namespace Mpc.SampleNUnit.Tests.Services
{
    [TestClass]
    public class CalculatePricesServiceTest
    {
        [TestMethod]
        public void CalculateProductPrice_WithNoPrice_ShouldReturnZero()
        {
            // Arrange
            var product = new Product();
            var service = new CalculatePricesService();

            // Act
            var price = service.CalculateProductPrice(product, 1);

            // Assert
            Assert.AreEqual(0, price);
        }
    }
}
