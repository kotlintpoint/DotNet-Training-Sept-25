using Bulky.Models;

namespace Bulky.DataAccess.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
        void Save();
    }
}
