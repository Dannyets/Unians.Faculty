using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Unians.Faculty.Data.Context;
using Unians.Faculty.Data.Interfaces;
using Unians.Faculty.Data.Models;

namespace Unians.Faculty.Data.Repositories
{
    public class FacultyRepository : BaseEntityFrameworkCoreRepository<DbFaculty>, IFacultyRepository
    {
        public FacultyRepository(FacultyDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<DbFaculty>> GetFacultiesForUniversity(int universityId)
        {
            var faculties = await _dbSet.Where(f => f.UniversityId == universityId).ToListAsync();

            return faculties;
        }
    }
}
