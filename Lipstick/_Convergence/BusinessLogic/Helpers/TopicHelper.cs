using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class TopicHelper : ITopicHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public TopicHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(TopicViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TopicViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TopicViewModel> GetByIdAsync(int id)
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

        public Task UpdateAsync(TopicViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
