using API.ContextObject;
using API.IRepositories;
using Dapper;
using SharedLibrary.DTO;

namespace API.Repositories
{
    public class MenuGroupRepository : IMenuGroupRepository
    {
        private readonly DatabaseContext _databaseContext;

        public MenuGroupRepository(DatabaseContext databaseContext) => _databaseContext = databaseContext;

        public async Task<IEnumerable<MenuGroup>> GetMenuGroups()
        {
            return null;
        }
    }
}
