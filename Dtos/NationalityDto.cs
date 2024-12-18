using System.ComponentModel.DataAnnotations;

namespace ChampionsLeague.Dtos
{
    public class NationalityDto
    {
        [Required]
        public string? CountryNameDto { get; set; }
    }
}