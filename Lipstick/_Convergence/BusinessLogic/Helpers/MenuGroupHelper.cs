using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class MenuGroupHelper : IMenuGroupHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public MenuGroupHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(MenuGroupViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MenuGroupViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MenuGroupViewModel> GetByIdAsync(int id)
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

        public Task UpdateAsync(MenuGroupViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
