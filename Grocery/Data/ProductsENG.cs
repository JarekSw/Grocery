using Grocery.Models;

namespace Grocery.Data
{
    public class ProductsENG
    {

        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Rye bread",
                Category="cat1",
                Price=10.5,

                Ingredients=new List<string>()
                {"flour","water","salt","yeast"}
            },
            new Product()
            {
                Id= 2,
                Name="Gingerbread",
                Category="cat1",
                Price=21,
                Ingredients=new List<string>()
                {"haney","yeast","water","sugar"}
            },
            new Product()
            {
                Id=3,
                Name="Sauerkraut",
                Category="cat2",
                Price=31.99,
                Ingredients= new List<string>()
                {"cabbage","salt","carrot","pepper"}
            }
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
