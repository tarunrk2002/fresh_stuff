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

        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<cats>().HasData(
        //        new cats { id = 1, name = "comedy", displayorder = 1 },
        //        new cats { id = 2, name = "romance", displayorder = 2 },
        //        new cats { id = 3, name = "romcom", displayorder = 3 });

        //}
    }
}
