using Lipstick._Convergence.DataAccess.IRepositories;
using Lipstick._Convergence.DataAccess.Repositories;

namespace Lipstick._Convergence.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext context;
        private bool disposed = false;
        public IArticleRepository ArticleRepository { get; private set; }
        public IBrandRepository BrandRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public ISubCategoryRepository SubCategoryRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public ITopicRepository TopicRepository { get; private set; }
        public IUnitRepository UnitRepository { get; private set; }
        public UnitOfWork(DatabaseContext context)
        {
            this.context = context;
            ArticleRepository = new ArticleRepository(context);
            BrandRepository = new BrandRepository(context);
            CategoryRepository = new MenuGroupRepository(context);
            SubCategoryRepository = new SubCategoryRepository(context);
            ProductRepository = new ProductRepository(context);
            TopicRepository = new TopicRepository(context);
            UnitRepository = new UnitRepository(context);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }
        public void Rollback()
        {
            throw new NotImplementedException();
        }
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
