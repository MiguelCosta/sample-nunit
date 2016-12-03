namespace Mpc.SampleNUnit.Services
{
    public class NamesFormatService
    {
        public string ProductWithCategory(string productName, string categoryName)
        {
            if(string.IsNullOrWhiteSpace(categoryName))
            {
                return productName;
            }
            else
            {
                return $"{productName} ({categoryName})";
            }
        }
    }
}
