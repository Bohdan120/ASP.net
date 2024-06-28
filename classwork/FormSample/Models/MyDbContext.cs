using Microsoft.EntityFrameworkCore;

namespace FormSample.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public MyDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PersonDbPu221ASP;Trusted_Connection=True;");
        }

    }
}
