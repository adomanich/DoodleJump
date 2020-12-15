using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace DoodleJump.db
{
    public class ScoreContext : DbContext
    {
        DbSet<Score> Scores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DoodleJump;Username=postgres;Password=arsen2001");
        }
    }
}
