namespace Mpc.SampleNUnit.Models
{
    public class Product
    {
        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
