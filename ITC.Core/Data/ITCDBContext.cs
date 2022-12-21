using System;
using Microsoft.EntityFrameworkCore;
using ITC.Data.Entities;
using System.Reflection;

namespace ITC.Core.Data
{
	public class ITCDBContext : DbContext
	{
        public ITCDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #region DB Set
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CoursePlans> CoursePlans { get; set; }
        public DbSet<EmpTasks> EmpTasks { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<LessonPlan> LessonPlans { get; set; }
        public DbSet<PartnersInformation> PartnersInformations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Schools> Schools { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<StudentInformation> StudentInformations { get; set; }
        #endregion
    }
}

