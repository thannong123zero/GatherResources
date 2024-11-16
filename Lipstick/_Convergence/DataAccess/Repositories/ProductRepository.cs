using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
