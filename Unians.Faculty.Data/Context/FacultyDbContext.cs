using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Unians.Faculty.Data.Models;

namespace Unians.Faculty.Data.Context
{
    public class FacultyDbContext : BaseMySqlDbContext
    {
        public FacultyDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            optionsBuilder.UseInMemoryDatabase("unians_faculty");
        }

        public DbSet<DbFaculty> Faculties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbFaculty>().HasKey(p => p.Id);

            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            AddInitialData(modelBuilder);
        }

        private void AddInitialData(ModelBuilder modelBuilder)
        {
            var faculty = new DbFaculty
            {
                Id = 1,
                Name = "מדעי המחשב",
                CreatedAt = DateTime.UtcNow,
                LastUdpatedAt = DateTime.UtcNow
            };

            var faculties = new List<DbFaculty> { faculty };

            modelBuilder.Entity<DbFaculty>().HasData(faculties);
        }
    }
}
