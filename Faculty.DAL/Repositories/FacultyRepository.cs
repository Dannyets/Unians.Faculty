using BaseRepositories.EntityFrameworkCore.Repositories;
using Faculty.DAL.Interfaces;
using Faculty.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.DAL.Repositories
{
    public class FacultyRepository : BaseEntityFrameworkCoreRepository<FacultyDbModel>, IFacultyRepository
    {
        public FacultyRepository(FacultyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
