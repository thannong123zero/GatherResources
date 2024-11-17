using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class BrandHelper : IBrandHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public BrandHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(BrandViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BrandViewModel>> GetAllAsync()
        {
            var data = await _unitOfWork.BrandRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BrandViewModel>>(data);
        }

        public Task<BrandViewModel> GetByIdAsync(int id)
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

        public Task UpdateAsync(BrandViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
