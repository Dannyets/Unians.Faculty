using BaseRepositories.EntityFrameworkCore.MySql;
using Faculty.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Faculty.DAL
{
    public class FacultyDbContext : BaseMySqlDbContext
    {
        public FacultyDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        public DbSet<FacultyDbModel> Faculties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacultyDbModel>().HasKey(p => p.Id);
        }
    }
}
