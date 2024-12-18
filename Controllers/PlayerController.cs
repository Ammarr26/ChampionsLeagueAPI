using ChampionsLeague.Dtos;
using ChampionsLeague.I;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChampionsLeague.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayer _repo;
        public PlayerController(IPlayer repo)
        {
            _repo = repo;
        }

        [HttpGet("GetAllPlayer")]
        public IActionResult GetAllPlayer()
        {
            var result = _repo.GetAllPlayer(); return Ok(result);
        }
    }
}