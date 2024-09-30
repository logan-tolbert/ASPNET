using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
