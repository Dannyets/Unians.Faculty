using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;

namespace Unians.Faculty.Data.Models
{
    public class DbFaculty : DbIdEntity
    {
        public string Name { get; set; }

        public int UniversityId { get; set; }
    }
}
