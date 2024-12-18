using ChampionsLeague.Dtos;

namespace ChampionsLeague.I
{
    public interface ITeam
    {
        public void AddAllTeam(AddAllTeamDto addAllTeamDto);
        public List<AddAllTeamDto> GetAllTeam();
        public void UpdateTeam(int id, AddAllTeamDto addAllTeamDto);
    }
}