using webgreen.DataAccess.data;
using webgreen.Models.Models;
using webgreen.Repository.IRepository;

namespace webgreen.Repository
{
    public class CatsRepository : Repository<cats>, ICatsRepository
    {
        private ApplicationDbContext data;
        public CatsRepository(ApplicationDbContext db) : base(db)
        {
            this.data = db;
        }

        public void save()
        {
           data.SaveChanges();
        }

        public void update(cats dat)
        {
            data.categories.Update(dat);
        }
    }
}
