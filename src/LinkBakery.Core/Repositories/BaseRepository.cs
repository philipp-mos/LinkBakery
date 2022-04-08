using LinkBakery.Core.Data;
using LinkBakery.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LinkBakery.Core.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _table;


        public BaseRepository(IConfiguration configuration)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            _context = new ApplicationDbContext(optionsBuilder.Options);
            _table = _context.Set<T>();
        }



        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _table.FindAsync(id);
        }

        public async void InsertAsync(T entity)
        {
            await _table.AddAsync(entity);
        }
        public void InsertAndSafeAsync(T entity)
        {
            InsertAsync(entity);
            SaveAsync();
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T? existing = _table.Find(id);

            if (existing != null)
            {
                _table.Remove(existing);
            }
        }

        public async void SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
