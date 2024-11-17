using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;
using Lipstick.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class SubCategoryHelper : ISubCategoryHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public SubCategoryHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(SubCategoryViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SubCategoryViewModel>> GetAllAsync()
        {
            var data = await _unitOfWork.SubCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<SubCategoryViewModel>>(data);
        }

        public Task<SubCategoryViewModel> GetByIdAsync(int id)
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

        public Task UpdateAsync(SubCategoryViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
