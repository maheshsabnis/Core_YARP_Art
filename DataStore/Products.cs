using CommoEntities;

namespace DataStore
{
    public class Products : List<Product>
    {
        public Products()
        {
            Add(new Product { ProductId = 1, ProductName = "Product 1" });
            Add(new Product { ProductId = 2, ProductName = "Product 2" });
            Add(new Product { ProductId = 3, ProductName = "Product 3" });
            Add(new Product { ProductId = 4, ProductName = "Product 4" });
            Add(new Product { ProductId = 5, ProductName = "Product 5" });
        }
    }
}
