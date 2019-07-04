using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Faculty.Api.Data.Models;
using Unians.Faculty.Data.Models;

namespace Unians.Faculty.Api.Mapper
{
    public class FacultyProfile : Profile
    {
        public FacultyProfile()
        {
            CreateMap<ApiFaculty, DbFaculty>().ReverseMap();
        }
    }
}
