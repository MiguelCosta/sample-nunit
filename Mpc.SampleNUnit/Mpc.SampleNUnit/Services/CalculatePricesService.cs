using Mpc.SampleNUnit.Models;

namespace Mpc.SampleNUnit.Services
{
    public class CalculatePricesService
    {
        public decimal CalculateProductPrice(Product product, int quantity)
        {
            return product.Price * quantity;
        }
    }
}
