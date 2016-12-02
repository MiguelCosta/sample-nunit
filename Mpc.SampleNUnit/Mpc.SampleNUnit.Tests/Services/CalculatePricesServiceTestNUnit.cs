using FluentAssertions;
using Mpc.SampleNUnit.Models;
using Mpc.SampleNUnit.Services;
using NUnit.Framework;

namespace Mpc.SampleNUnit.Tests.Services
{
    [TestFixture]
    public class CalculatePricesServiceTestNUnit
    {
        [Test]
        public void CalculateProductPrice_WithNoPrice_ShouldReturnZero()
        {
            // Arrange
            var product = new Product();
            var service = new CalculatePricesService();

            // Act
            var price = service.CalculateProductPrice(product, 1);

            // Assert
            price.Should().Be(0);
        }
    }
}
