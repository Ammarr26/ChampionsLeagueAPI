namespace ChampionsLeague.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string? PlayerName { get; set; }
        public Team? team { get; set; }
        public Nationality? nationality { get; set; }
    }
}