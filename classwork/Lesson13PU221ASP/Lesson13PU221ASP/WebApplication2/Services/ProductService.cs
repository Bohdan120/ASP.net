using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ProductService
    {
        private Products products;
        public ProductService()
        {
            products = new Products();
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public List<Product> AddProduct(Product product)
        {
            products.Add(product);
            return products;
        }
    }
}
