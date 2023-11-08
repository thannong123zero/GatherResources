using ShareLibrary.DTO;

namespace API.IRepositories
{
    public interface IMenuGroupRepository
    {
        public Task<IEnumerable<MenuGroup>> GetMenuGroups();
    }
}
