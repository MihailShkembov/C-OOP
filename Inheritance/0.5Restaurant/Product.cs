
namespace Restaurant
{
    public class Product
    {
        public Product(string name,decimal price)
        {
            this.Name = name;
            this.Price = (decimal)price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
