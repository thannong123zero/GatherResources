using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class UnitRepository : GenericRepository<UnitDTO>, IUnitRepository
    {
        public UnitRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
