namespace UniversityClasses
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityDB : DbContext
    {
       
        public UniversityDB()
            : base("name=UniversityDB")
        {
        }
        

        public virtual DbSet<Audience> Audiences { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
    }
   
}