namespace ChampionsLeague.Models
{
    public class Nationality
    {
        public int NationalityID { get; set; }
        public string? CountryName { get; set; }
        public List<Player>? players { get; set; }
    }
}