using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Logotech.API.Data;
using Logotech.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Logotech.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ILogotechRepository _repo;
        private readonly IMapper _mapper;
        public PatientsController(ILogotechRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            var patients = await _repo.GetPatients();

            var patientsToReturn = _mapper.Map<IEnumerable<PatientForListDto>>(patients);

            return Ok(patientsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await _repo.GetPatient(id);

            var patientToReturn = _mapper.Map<PatientForDetailDto>(patient);

            return Ok(patientToReturn);
        }       
    }
}