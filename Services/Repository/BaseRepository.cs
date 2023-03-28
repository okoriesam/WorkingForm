using MetrosoftForm.Data;
using MetrosoftForm.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MetrosoftForm.Services.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbset;
        public BaseRepository(ApplicationDbContext context)
        {
            _context= context;
            dbset = context.Set<T>();   
        }
        public async Task<T> CreateAsync(T entity)
        {
            await dbset.AddAsync(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
