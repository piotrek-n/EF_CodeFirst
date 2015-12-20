using System.Data.Entity;

namespace CodeFirst
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("SchoolDBConnectionString")
        {
            // Database.SetInitializer<SchoolContext>(null);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, CodeFirst.Migrations.Configuration>("SchoolDBConnectionString"));
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Standard> Standards { get; set; }

        public DbSet<Resource> Resources { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }
    }
}