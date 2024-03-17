using API.IRepositories;
using API.Repositories;
using AutoMapper;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class MenuGroupHelper
    {
        private UnitOfWork UnitOfWork = new UnitOfWork();
        private IMapper _mapper;
        public MenuGroupHelper(IMapper mapper) {
            _mapper = mapper;
        
        }
        public async Task AddMenuGroup(MenuGroupUI model)
        {
            MenuGroup entity = _mapper.Map<MenuGroup>(model);
            await UnitOfWork.MenuGroupRepository.Create(entity);
            UnitOfWork.Save();
        }

    }
}
