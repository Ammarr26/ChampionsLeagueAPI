using ChampionsLeague.Models;
using Microsoft.EntityFrameworkCore;

namespace ChampionsLeague.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
    }
}