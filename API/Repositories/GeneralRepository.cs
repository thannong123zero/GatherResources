using API.ContextObject;
using API.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class GeneralRepository<Entity> : IGeneralRepository<Entity> where Entity : class
    {
        private readonly DatabaseContext _dbContext;
        private readonly DbSet<Entity> _dbSet;

        public GeneralRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Entity>();
        }
        public void Add(Entity entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public List<Entity> GetAll()
        {
            var list = _dbSet.AsQueryable().ToList();
            return list;
        }

        public Entity GetByID()
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
