using ChampionsLeague.DBContext;
using ChampionsLeague.Dtos;
using ChampionsLeague.I;
using ChampionsLeague.Models;
using Microsoft.EntityFrameworkCore;

namespace ChampionsLeague.Repos
{
    public class TeamRepo : ITeam
    {
        private readonly AppDbContext _context;
        public TeamRepo(AppDbContext context) 
        {
            _context = context;
        }
        public void AddAllTeam(AddAllTeamDto addAllTeamDto)
        {
            Team team = new Team
            {
                TeamName = addAllTeamDto.TeamNameDto,

                players = addAllTeamDto.playerDtos
                .Select(player => new Player
                {
                    PlayerName = player.PlayerNameDto,

                    nationality = new Nationality
                    {CountryName = player.nationalityDto.CountryNameDto}

                }).ToList(),
            };
            _context.Teams.Add(team);
            _context.SaveChanges();
        }

        public List<AddAllTeamDto> GetAllTeam()
        {
            var result = _context.Teams
            .Select(x => new AddAllTeamDto
            {
                TeamNameDto = x.TeamName,

                playerDtos = x.players
                .Select(player => new PlayerDto
                {
                    PlayerNameDto = player.PlayerName,

                    nationalityDto = new NationalityDto
                    {CountryNameDto = player.nationality.CountryName},

                }).ToList(),
            }).ToList();
            return result;
        }
        
        public void UpdateTeam(int id, AddAllTeamDto addAllTeamDto)
        {
            var result = _context.Teams.FirstOrDefault(x => x.TeamID == id);
            if (result != null)
            {
                result.TeamName = addAllTeamDto.TeamNameDto;

                result.players = addAllTeamDto.playerDtos
                .Select(x => new Player
                {
                    PlayerName = x.PlayerNameDto,

                    nationality = new Nationality
                    {CountryName = x.nationalityDto.CountryNameDto}

                }).ToList();
            }
            _context.Teams.Update(result);
            _context.SaveChanges();
        }
    }
}