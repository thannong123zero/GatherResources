using API.ContextObject;
using API.IRepositories;

namespace API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext context;
        private bool disposed = false;
        private MenuGroupRepository menuGroupRepository;
        public MenuGroupRepository MenuGroupRepository
        {
            get
            {

                if (this.menuGroupRepository == null)
                {
                    this.menuGroupRepository = new MenuGroupRepository(context);
                }
                return menuGroupRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public UnitOfWork(DatabaseContext databaseContext)
        {
            context = databaseContext;
        }
    }
}
