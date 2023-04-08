using Core.Entities;

namespace Core.Interface
{
    public interface IProductRepository
    {

        Task<IReadOnlyList<Product>> GetProductAsync();
        Task<Product> GetProductsByIdAsync(int id);


    }
}
