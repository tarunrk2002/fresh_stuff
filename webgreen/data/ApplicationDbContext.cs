using Microsoft.EntityFrameworkCore;
using webgreen.Models;

namespace webgreen.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }

        public DbSet<cats> categories { get; set; }
    }
}
