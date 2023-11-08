using API.DBContext;
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
            string query = "select * from MenuGroup";
            using(var connection = _databaseContext.CreateConnection())
            {
                var menuGroups = await connection.QueryAsync<MenuGroup>(query);
                return menuGroups.ToList();
            }
        }
    }
}
