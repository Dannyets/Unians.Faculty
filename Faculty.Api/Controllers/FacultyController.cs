using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using Faculty.Api.Models;
using Faculty.DAL.Interfaces;
using Faculty.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Api.Controllers
{
    public class FacultyController : BaseEfCrudController<FacultyApiModel, FacultyDbModel>
    {
        public FacultyController(IFacultyRepository repository, 
                                 IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
