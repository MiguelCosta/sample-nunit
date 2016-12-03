using FluentAssertions;
using Mpc.SampleNUnit.Models;
using Mpc.SampleNUnit.Services;
using NUnit.Framework;

namespace Mpc.SampleNUnit.Tests.Services
{
    [TestFixture]
    public class QuantityAvailableServiceTest
    {
        private QuantityAvailableService _service;

        [SetUp]
        public void Begin()
        {
            _service = new QuantityAvailableService();
        }

        [Test]
        public void CalculateNewQuantity_WithQuantityDecreaseNegative_ShouldBeDouble()
        {
            // Arrange
            var product = new Product { QuantityAvailable = 1.1 };

            // Act
            var result = _service.CalculateNewQuantity(product, -2.2);

            // Assert - with floating problem
            //result.Should().Be(3.3);
            //Assert.That(result, Is.EqualTo(3.3));

            // Assert - without floating problem
            result.Should().BeApproximately(3.3, 0.0001);
            Assert.That(result, Is.EqualTo(3.3).Within(0.0001));
            // can be differ in 1%
            Assert.That(result, Is.EqualTo(3.3).Within(1).Percent); 
        }
    }
}
