using webgreen.DataAccess.data;
using webgreen.Models.Models;
using webgreen.Repository.IRepository;

namespace webgreen.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext data;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            this.data = db;
        }

       

        public void update(Product dat)
        {
            data.products.Update(dat);
        }
    }
}
