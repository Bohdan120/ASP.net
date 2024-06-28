using Microsoft.EntityFrameworkCore;

namespace dz_7._06_.Models
{
    public class InfoContext: DbContext
    {
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<ProfessionalSkills> ProfessionalSkills { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }

       public InfoContext(DbContextOptions<InfoContext> options)
            : base(options) 
       {
            Database.EnsureCreated();
       }
    }
}
