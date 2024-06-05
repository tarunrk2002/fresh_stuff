using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using webgreen.DataAccess.data;
using webgreen.Repository.IRepository;


namespace webgreen.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbase;
        readonly DbSet<T> dbSet;
        public Repository(ApplicationDbContext dbase)
        {
            this.dbase = dbase;
            this.dbSet = dbase.Set<T>();
           
        }
        public void add(T entity)
        {
          dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void removerange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
        //public void ddd(IServiceCollection services)
        //{
        //    services.
        //}
    }
}
