namespace ProductAPI.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Product(string productName, decimal price, string description)
        {
            ProductName = productName;
            Price = price;
            Description = description;
        }
    }
}
