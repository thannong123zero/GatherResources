using API.ContextObject;
using API.IRepositories;
using API.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;

namespace API.Helpers
{
    public class MenuGroupHelper
    {
        private UnitOfWork _unitOfWork ;
        private IMapper _mapper;
        public MenuGroupHelper(IMapper mapper,UnitOfWork unitOfWork) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        
        }
        public async Task<IEnumerable<MenuGroupUI>> GetMenuGroups()
        {
            return null;
        }
        public async Task<MenuGroupUI> GetMenuGroupByID(string ID)
        {
            return null;
        }
        public async Task AddMenuGroup(MenuGroupUI model)
        {
            try
            {
                MenuGroup entity = _mapper.Map<MenuGroup>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.MenuGroupRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateMenuGroup(MenuGroupUI model)
        {
            try
            {
                MenuGroup entity = _mapper.Map<MenuGroup>(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteMenuGroup(string ID)
        {
        }
    }
}
