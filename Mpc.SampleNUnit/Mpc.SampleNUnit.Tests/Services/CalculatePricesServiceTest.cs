using FluentAssertions;
using Mpc.SampleNUnit.Models;
using Mpc.SampleNUnit.Services;
using NUnit.Framework;

namespace Mpc.SampleNUnit.Tests.Services
{
    [TestFixture]
    public class CalculatePricesServiceTest
    {
        private CalculatePricesService _service;

        [SetUp]
        public void Begin()
        {
            _service = new CalculatePricesService();
        }

        [Test]
        public void CalculateProductPrice_WithNoPrice_ShouldReturnZero()
        {
            // Arrange
            var product = new Product();

            // Act
            var price = _service.CalculateProductPrice(product, 1);

            // Assert
            price.Should().Be(0);
        }

        [Test]
        public void CalculateProductPrice_WithPriceAndQuantityFloat_ShouldReturnZero()
        {
            // Arrange
            var product = new Product { Price = 1.1M };

            // Act
            var price = _service.CalculateProductPrice(product, 2.2);

            // Assert
            price.Should().Be(2.42M);
        }

        [Test]
        public void CalculateProductPrice_WithPriceAndQuantityInt_ShouldReturnZero()
        {
            // Arrange
            var product = new Product { Price = 10 };
            var service = new CalculatePricesService();

            // Act
            var price = service.CalculateProductPrice(product, 2);

            // Assert
            price.Should().Be(20);
        }
    }
}
