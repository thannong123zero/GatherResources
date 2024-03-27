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
        
        private MenuItemRepository menuItemRepository;
        public MenuItemRepository MenuItemRepository
        {
            get
            {

                if (this.menuItemRepository == null)
                {
                    this.menuItemRepository = new MenuItemRepository(context);
                }
                return menuItemRepository;
            }
        }
        private UnitRepository unitRepository;
        public UnitRepository UnitRepository
        {
            get
            {

                if (this.unitRepository == null)
                {
                    this.unitRepository = new UnitRepository(context);
                }
                return unitRepository;
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
