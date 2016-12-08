using System.Data.Entity;

namespace University_DB
{
    public class UniversityDB : DbContext
    {
        public UniversityDB()
            : base("University_DB")
        { }

        public DbSet<Software> Software { get; set; }
        public DbSet<SoftwarePackage> SoftwarePackage { get; set; }
        public DbSet<Audience> Audience { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Group> Group { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
