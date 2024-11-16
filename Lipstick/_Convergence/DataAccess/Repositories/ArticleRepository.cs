using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
