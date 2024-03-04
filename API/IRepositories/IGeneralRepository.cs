namespace API.IRepositories
{
    public interface IGeneralRepository<Entity> where Entity : class
    {
        void Add(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
        Entity GetByID();
        List<Entity> GetAll();
    }
}
