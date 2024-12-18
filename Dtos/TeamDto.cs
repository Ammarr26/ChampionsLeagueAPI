namespace ChampionsLeague.Dtos
{
    public class TeamDto
    {
        public string? TeamNameDto { get; set; }
    }
    public class AddAllTeamDto
    {
        public string? TeamNameDto { get; set; }
        public List<PlayerDto>? playerDtos { get; set; }
    }
}