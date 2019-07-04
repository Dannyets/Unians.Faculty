using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unians.Faculty.Data.Models;

namespace Unians.Faculty.Data.Interfaces
{
    public interface IFacultyRepository : IEfRepository<DbFaculty>
    {
        Task<List<DbFaculty>> GetFacultiesForUniversity(int universityId);
    }
}
