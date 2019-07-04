using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Faculty.Api.Data.Models;
using Unians.Faculty.Data.Interfaces;
using Unians.Faculty.Data.Models;

namespace Faculty.Api.Controllers
{
    public class FacultyController : BaseEfCrudController<ApiFaculty, DbFaculty>
    {
        private IFacultyRepository _repository;

        public FacultyController(IFacultyRepository repository, 
                                 IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<ApiFaculty>> GetFacultiesForUniversity(int universityId)
        {
            var dbFaculties = await _repository.GetFacultiesForUniversity(universityId);

            var apiFaculties = dbFaculties.Select(f => _mapper.Map<ApiFaculty>(f));

            return apiFaculties;
        }
    }
}
