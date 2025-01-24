using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DatabaseContext _databaseContext;
        private DbSet<T> _table = null;
        public Repository(DatabaseContext db)
        {
            _databaseContext = db;
            _table = _databaseContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _table.ToList();
        }

        public async Task<T> Add(T entity)
        {
            _table.Add(entity);
            _databaseContext.SaveChanges();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _databaseContext.Entry(entity).State = EntityState.Modified;
            _databaseContext.SaveChanges();
            return entity;
        }

        public async Task<T> Delete(object id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
            _databaseContext.SaveChanges();
            return entity;
        }

        public async Task<T> GetById(int id)
        {
            return _table.Find(id);
        }
    }
}
