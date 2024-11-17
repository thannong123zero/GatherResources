using AutoMapper;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class ArticleHelper: IArticleHelper 
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ArticleHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        public Task CreateAsync(ArticleViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArticleViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArticleViewModel> GetByIdAsync(int id)
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

        public Task UpdateAsync(ArticleViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
