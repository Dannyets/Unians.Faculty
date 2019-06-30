using BaseRepositories.EntityFrameworkCore.Models.Interfaces;
using Faculty.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.DAL.Interfaces
{
    public interface IFacultyRepository : IEfRepository<FacultyDbModel>
    {
    }
}
