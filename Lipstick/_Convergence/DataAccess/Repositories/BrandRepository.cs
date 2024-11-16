using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
