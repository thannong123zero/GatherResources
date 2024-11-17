using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;
using System.Linq.Expressions;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class SubCategoryRepository : GenericRepository<SubCategoryDTO>, ISubCategoryRepository
    {
        public SubCategoryRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
