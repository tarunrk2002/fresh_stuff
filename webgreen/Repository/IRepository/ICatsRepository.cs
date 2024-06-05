using webgreen.Models.Models;

namespace webgreen.Repository.IRepository
{
    public interface ICatsRepository:IRepository<cats>

    {
        void update(cats data);
        

        
        
    }

}
