namespace ChampionsLeague.Dtos
{
    public class PlayerDto
    {
        public string? PlayerNameDto { get; set; }
        public NationalityDto? nationalityDto { get; set; }
    }
    public class AddAllPlayerDto
    {
        public string? PlayerNameDto { get; set; }
        public TeamDto? teamDto { get; set; }
        public NationalityDto? nationalityDto { get; set; }
    }
}