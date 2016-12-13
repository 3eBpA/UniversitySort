namespace WinFormUniversitySort
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using University_DB;

    public class ModelDb : DbContext
    {
        
        public ModelDb()
            : base("name=ModelDb")
        {
        }

       // public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Audience> Audiences { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<SoftwarePackage> SoftwarePackages { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
    }

    
}