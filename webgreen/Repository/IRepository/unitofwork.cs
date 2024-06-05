using webgreen.DataAccess.data;
using webgreen.Models.Models;

namespace webgreen.Repository.IRepository
{
    public class unitofwork : Iunitofwork
    {
        private ApplicationDbContext data;
        public ICatsRepository Cats { get; private set; }
        public unitofwork(ApplicationDbContext data)
        {
            this.data = data;
            Cats = new CatsRepository(data);
        }
        
        

        public void save()
        {
           data.SaveChanges();
        }
    }
}
