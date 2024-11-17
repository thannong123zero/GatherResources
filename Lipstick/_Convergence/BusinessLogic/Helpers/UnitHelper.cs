using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class UnitHelper : IUnitHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public UnitHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(UnitViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UnitViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UnitViewModel> GetByIdAsync(int id)
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

        public Task UpdateAsync(UnitViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
