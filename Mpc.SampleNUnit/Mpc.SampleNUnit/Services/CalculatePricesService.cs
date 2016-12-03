using Mpc.SampleNUnit.Models;

namespace Mpc.SampleNUnit.Services
{
    public class CalculatePricesService
    {
        public decimal CalculateProductPrice(Product product, double quantity)
        {
            return product.Price * (decimal) quantity;
        }
    }
}
