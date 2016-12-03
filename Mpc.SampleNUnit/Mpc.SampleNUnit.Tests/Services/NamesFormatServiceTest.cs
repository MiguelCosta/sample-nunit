using FluentAssertions;
using Mpc.SampleNUnit.Services;
using NUnit.Framework;

namespace Mpc.SampleNUnit.Tests.Services
{
    [TestFixture]
    public class NamesFormatServiceTest
    {
        [Test]
        public void ProductWithCategory_IgnoreCase_ShouldInclude2Names()
        {
            // Arrange
            var service = new NamesFormatService();
            var productName = "prod1";
            var categoryName = "categ1";

            // Act
            var result = service.ProductWithCategory(productName, categoryName);

            // Assert
            Assert.That(result, Is.EqualTo("PROD1 (Categ1)").IgnoreCase); // NUnit
            result.Should().BeEquivalentTo("PROD1 (Categ1)"); // FluentAssertions
        }

        [Test]
        public void ProductWithCategory_OrderNames_ShouldBeProductNameFirst()
        {
            // Arrange
            var service = new NamesFormatService();
            var productName = "prod1";
            var categoryName = "categ1";

            // Act
            var result = service.ProductWithCategory(productName, categoryName);

            // Assert
            Assert.That(result, Is.Not.EqualTo("categ1 (prod1)")); // NUnit
            result.Should().NotBe("categ1 (prod1)"); // FluentAssertions
        }

        [Test]
        public void ProductWithCategory_WithoutCategoryName_ShouldBeProductName()
        {
            // Arrange
            var service = new NamesFormatService();
            var productName = "prod1";
            var categoryName = string.Empty;

            // Act
            var result = service.ProductWithCategory(productName, categoryName);

            // Assert
            result.Should().Be("prod1");
        }

        [Test]
        public void ProductWithCategory_WithProductAndCategoryName_ShouldInclude2Names()
        {
            // Arrange
            var service = new NamesFormatService();
            var productName = "prod1";
            var categoryName = "categ1";

            // Act
            var result = service.ProductWithCategory(productName, categoryName);

            // Assert
            result.Should().Be("prod1 (categ1)");
        }
    }
}
