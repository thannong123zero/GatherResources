using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class BlogRepository : GenericRepository<BlogDTO>, IBlogRepository
    {
        public BlogRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
