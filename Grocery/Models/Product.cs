namespace Grocery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public List<string>? Ingredients { get; set; }
        public double? Price { get; set; }
    }
}
