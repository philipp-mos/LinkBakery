namespace LinkBakery.Application.Contracts.Persistence
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<T> InsertAsync(T entity);
        Task<T> InsertAndSafeAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object id);
        Task SaveAsync();
    }
}
