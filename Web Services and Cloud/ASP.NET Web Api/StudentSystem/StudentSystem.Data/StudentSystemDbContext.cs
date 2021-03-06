﻿namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Data.Migrations;
    using StudentSystem.Models;

    public class StudentSystemDbContext : DbContext, IStudentSystemDbContext
    {
        public StudentSystemDbContext() : base("StudentSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
