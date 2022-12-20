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


        #endregion
    }
}

