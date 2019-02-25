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
    public class PraticiensController : ControllerBase
    {
        private readonly ILogotechRepository _repo;
        private readonly IMapper _mapper;
        public PraticiensController(ILogotechRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetDocteurs()
        {
            var praticiens = await _repo.GetDocteurs();

            var praticiensToReturn = _mapper.Map<IEnumerable<DocteurForListDto>>(praticiens);

            return Ok(praticiensToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocteur(int id)
        {
            var praticien = await _repo.GetDocteur(id);

            var praticienToReturn = _mapper.Map<DocteurForDetailDto>(praticien);

            return Ok(praticienToReturn);
        }
    }
}