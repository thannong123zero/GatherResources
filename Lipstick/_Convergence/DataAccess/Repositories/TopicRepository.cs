using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class TopicRepository : GenericRepository<TopicDTO>, ITopicRepository
    {
        public TopicRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
