namespace LinkBakery.Core.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        void SaveAsync();
    }
}
