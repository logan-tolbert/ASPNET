using static Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAllProducts();
    }
}
