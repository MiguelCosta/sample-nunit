using Mpc.SampleNUnit.Models;

namespace Mpc.SampleNUnit.Services
{
    public class QuantityAvailableService
    {
        public double CalculateNewQuantity(Product product, double quantityDecrease)
        {
            return product.QuantityAvailable - quantityDecrease;
        }
    }
}
