using Grocery.Models;

namespace Grocery.Data
{
    public static class ProductsPL
    {
        
        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Chleb żytni",
                Category="cat1",
                Price=10.5,
               
                Ingredients=new List<string>()
                {"mąka","woda","sól","drożdże"}
            },
            new Product()
            {
                Id= 2,
                Name="Piernik",
                Category="cat1",
                Price=21,
                Ingredients=new List<string>()
                {"miód","drożdze","woda","cukier"}
            },
            new Product()
            {
                Id=3,
                Name="Kapusta kiszona",
                Category="cat2",
                Price=31.99,
                Ingredients= new List<string>()
                {"kapusta","sól","marchew","pieprz"}
            },
           

        };
        public static List<Product> Produkty
        {
            get
            {
                return products;
            }
        }
    }
}
