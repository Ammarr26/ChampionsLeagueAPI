using ChampionsLeague.Dtos;
using ChampionsLeague.I;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChampionsLeague.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeam _repo;
        public TeamController(ITeam repo)
        {
            _repo = repo;
        }

        [HttpPost("AddAllTeam")]
        public IActionResult AddAllTeam(AddAllTeamDto addAllTeamDto)
        {
            _repo.AddAllTeam(addAllTeamDto); return Ok();
        }

        [HttpGet("GetAllTeam")]
        public IActionResult GetAllTeam()
        {
            var result = _repo.GetAllTeam(); return Ok(result);
        }

        [HttpPut("UpdateTeam")]
        public IActionResult UpdateTeam(int id, AddAllTeamDto addAllTeamDto)
        {
            _repo.UpdateTeam(id, addAllTeamDto); return Ok();
        }
    }
}