using Core.Entities;
using Core.Interface;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;
        public ProductRepository(StoreContext context)
        {
            _storeContext = context;
        }
        public async Task<IReadOnlyList<Product>> GetProductAsync()
        {
            return await _storeContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
            Product? product = await _storeContext.Products.FindAsync(id);
            return product ?? throw new NotFoundException($"Product with ID '{id}' not found.", id); ;
        }
    }
}
