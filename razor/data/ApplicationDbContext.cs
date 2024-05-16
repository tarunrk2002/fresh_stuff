using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using razor.Models;

namespace razor.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<cate> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cate>().HasData(
                new cate { id = 1, name = "comedy", displayorder = 1 },
                new cate { id = 2, name = "romance", displayorder = 2 },
                new cate { id = 3, name = "romcom", displayorder = 3 });

        }


    }
}

