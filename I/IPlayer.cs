using ChampionsLeague.Dtos;

namespace ChampionsLeague.I
{
    public interface IPlayer
    {
        public List<AddAllPlayerDto> GetAllPlayer();
    }
}