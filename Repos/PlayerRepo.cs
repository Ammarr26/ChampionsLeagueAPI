using ChampionsLeague.DBContext;
using ChampionsLeague.Dtos;
using ChampionsLeague.I;
using ChampionsLeague.Models;
using Microsoft.EntityFrameworkCore;

namespace ChampionsLeague.Repos
{
    public class PlayerRepo : IPlayer
    {
        private readonly AppDbContext _context;
        public PlayerRepo(AppDbContext context) 
        {
            _context = context;
        }
        public List<AddAllPlayerDto> GetAllPlayer()
        {
            var result = _context.Players.Include(x => x.team).Include(x => x.nationality)
            .Select(m => new AddAllPlayerDto
            {
                PlayerNameDto = m.PlayerName,

                teamDto = new TeamDto
                {TeamNameDto = m.team.TeamName},

                nationalityDto = new NationalityDto
                {CountryNameDto = m.nationality.CountryName}

            }).ToList();
            return result;
        }
    }
}