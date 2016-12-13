using System.Data.Entity;

namespace University_DB
{
    public class UniversityDB : DbContext
    {
        public UniversityDB()
<<<<<<< HEAD:UniversitySort/UniversityDataBase/University_DB.cs
            : base("UniversityDB")
=======
            : base("ModelDb")
>>>>>>> 2a8dba2a931ab8707c74fed8f947c799941de0a8:UniversityDataBase/University_DB.cs
        { }

        public DbSet<Software> Software { get; set; }
        public DbSet<SoftwarePackage> SoftwarePackage { get; set; }
        public DbSet<Audience> Audience { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Group> Group { get; set; }

       
    }
}
