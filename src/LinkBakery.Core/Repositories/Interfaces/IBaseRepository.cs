namespace LinkBakery.Core.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        void InsertAsync(T entity);
        void InsertAndSafeAsync(T entity);
        void Update(T entity);
        void Delete(object id);
        void SaveAsync();
    }
}
