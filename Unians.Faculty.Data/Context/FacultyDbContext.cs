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
            var faculties = new List<DbFaculty>
            {
                new DbFaculty
                {
                    Id = 1,
                    UniversityId = 1,
                    Name = "מדעי המחשב",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow,
                },
                new DbFaculty
                {
                    Id = 2,
                    UniversityId = 2,
                    Name = "מדעי המחשב",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow,
                },
                new DbFaculty
                {
                    Id = 3,
                    UniversityId = 3,
                    Name = "מדעי המחשב",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow,
                },
                new DbFaculty
                {
                    Id = 4,
                    UniversityId = 1,
                    Name = "רפואה",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow,
                },
                new DbFaculty
                {
                    Id = 5,
                    UniversityId = 1,
                    Name = "הנדסת מכונות",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow,
                }
            };

            modelBuilder.Entity<DbFaculty>().HasData(faculties);
        }
    }
}
