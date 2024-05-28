using System.Linq.Expressions;
using webgreen.Models.Models;

namespace webgreen.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void add (T entity);
        void remove (T entity);
        T Get(Expression<Func<T, bool>> filter);
        void delete (T entity);

        void deleterange (T entity);

    }
}
