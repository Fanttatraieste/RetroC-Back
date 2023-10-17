using FootballIconsCAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballIconsCAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost; Database=IconsDB; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        public DbSet<BallonDor> BallonDors { get; set; }
        public DbSet<ChampionsCup> ChampionsCups { get; set; }
        public DbSet<ContinentalCup> ContinentalCups { get;set; }
        public DbSet<DomesticCup> DomesticCups { get;  set; }

        public DbSet<DomesticLeague> DomesticLeagues { get; set; }
        public DbSet<DomesticSuperCup> DomesticSuperCups { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<NationPlayerStats> NationPlayerStats { get; set;}
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPlayerStats> TeamPlayerStats { get; set; }
        public DbSet<UEFACup> UEFACups { get; set; }
        public DbSet<UEFASuperCup> UEFASuperCups { get; set; }
        public DbSet<WinnersCup> WinnersCups { get; set;}
        public DbSet<WorldCup> WorldCups { get; set; }
    }
}
