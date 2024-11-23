using Lipstick._Convergence.DataAccess.IRepositories;

namespace Lipstick._Convergence.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository BlogRepository { get; }
        IBrandRepository BrandRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ISubCategoryRepository SubCategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        ITopicRepository TopicRepository { get; }
        IUnitRepository UnitRepository { get; }
        void BeginTransaction();
        void Commit();
        void Rollback();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
