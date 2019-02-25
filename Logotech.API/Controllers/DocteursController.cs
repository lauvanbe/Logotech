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
    public class DocteursController : ControllerBase
    {
        private readonly ILogotechRepository _repo;
        private readonly IMapper _mapper;
        public DocteursController(ILogotechRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetDocteurs()
        {
            var docteurs = await _repo.GetDocteurs();

            var docteursToReturn = _mapper.Map<IEnumerable<DocteurForListDto>>(docteurs);

            return Ok(docteursToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocteur(int id)
        {
            var docteur = await _repo.GetDocteur(id);

            var docteurToReturn = _mapper.Map<DocteurForDetailDto>(docteur);

            return Ok(docteurToReturn);
        }
    }
}