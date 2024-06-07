using webgreen.Models.Models;

namespace webgreen.Repository.IRepository
{
    public interface IProductRepository:IRepository<Product>

    {
        void update(Product data);
        

        
        
    }

}
