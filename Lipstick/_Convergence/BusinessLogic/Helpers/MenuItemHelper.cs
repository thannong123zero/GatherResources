using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;
using Lipstick.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class MenuItemHelper : IMenuItemHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public MenuItemHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(MenuItemViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MenuItemViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MenuItemViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RestoreAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MenuItemViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
