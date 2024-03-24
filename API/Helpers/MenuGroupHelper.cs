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
            var listMenuGroup =  await _unitOfWork.MenuGroupRepository.GetAll();
            IEnumerable<MenuGroupUI> listMenuGroupUI = new List<MenuGroupUI>();
            listMenuGroupUI = _mapper.Map<IEnumerable<MenuGroupUI>>(listMenuGroup);

            return listMenuGroupUI;
        }
        public async Task<MenuGroupUI> GetMenuGroupByID(string ID)
        {
            if(!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var menuGroup  = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));
            MenuGroupUI menuGroupUI = _mapper.Map<MenuGroupUI>(menuGroup);
            return menuGroupUI;
        }
        public async Task AddMenuGroup(MenuGroupUI model)
        {
            try
            {
                MenuGroup entity = _mapper.Map<MenuGroup>(model);
                entity.ID = Guid.NewGuid();
                //tam thoi gan o day
                entity.IsDeleted = false;
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
                await _unitOfWork.MenuGroupRepository.Update(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task DeleteMenuGroupByID(string ID)
        {
            await _unitOfWork.MenuGroupRepository.Delete(Guid.Parse(ID));
            _unitOfWork.Save();
        }
        public async Task SoftDeleteMenuGroupByID(string ID)
        {
            var menuGroup = await _unitOfWork.MenuGroupRepository.GetById(Guid.Parse(ID));
            if(menuGroup != null)
            {
                menuGroup.IsDeleted = true;
                await _unitOfWork.MenuGroupRepository.Update(menuGroup);
                _unitOfWork.Save();
            }
        }
    }
}
