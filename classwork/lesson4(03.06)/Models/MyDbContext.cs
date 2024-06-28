using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace lesson4_03._06_.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MyDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductDbPu221ASP;Trusted_Connection=True;");
        }
    }
}
