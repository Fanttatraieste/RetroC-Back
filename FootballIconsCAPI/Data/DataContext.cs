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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Nation>()
            //    .HasMany(n => n.WorldCups)
            //    .WithOne(w => w.Winner)
            //    .HasForeignKey(w => w.WorldCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Nation>()
            //    .HasMany(n => n.WorldCupsRunnerUps)
            //    .WithOne(w => w.RunnerUp)
            //    .HasForeignKey(w => w.WorldCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Nation>()
            //    .HasMany(n => n.WorldCupThirdPlace)
            //    .WithOne(w => w.ThirdPlace)
            //    .HasForeignKey(w => w.WorldCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Nation>()
            //    .HasMany(n => n.ContinentalCups)
            //    .WithOne(w => w.Winner)
            //    .HasForeignKey(w => w.ContinentalCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Nation>()
            //    .HasMany(n => n.ContinentalCupsRunnerUps)
            //    .WithOne(w => w.RunnerUp)
            //    .HasForeignKey(w => w.ContinentalCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Nation>()
            //    .HasMany(n => n.ContinentalCupsThirdPlace)
            //    .WithOne(w => w.ThirdPlace)
            //    .HasForeignKey(w => w.ContinentalCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.ChampionsCupWinner)
            //    .WithOne(c => c.Winner)
            //    .HasForeignKey(t => t.ChampionsCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Team>()
            //   .HasMany(t => t.ChampionsCupRunnerUp)
            //   .WithOne(c => c.RunnerUp)
            //   .HasForeignKey(t => t.ChampionsCupID)
            //   .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.DomesticCups)
            //    .WithOne(c => c.Winner)
            //    .HasForeignKey(c => c.DomesticCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.DomestiLeagues)
            //    .WithOne(l => l.Winner)
            //    .HasForeignKey(l => l.DomesticLeagueID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.DomesticSuperCups)
            //    .WithOne(c => c.Winner)
            //    .HasForeignKey(c => c.DomesticSuperCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.UEFACups)
            //    .WithOne(u => u.Winner)
            //    .HasForeignKey(u => u.UEFACupID)
            //    .OnDelete(DeleteBehavior.NoAction); 

            //modelBuilder.Entity<Team>() 
            //    .HasMany(t => t.UEFACupsRunnerUps)
            //    .WithOne(u => u.RunnerUp)
            //    .HasForeignKey(u => u.UEFACupID)
            //    .OnDelete(DeleteBehavior.NoAction); 

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.WinnersCups)
            //    .WithOne(u => u.Winner)
            //    .HasForeignKey(u => u.WinnersCupID)
            //    .OnDelete(DeleteBehavior.NoAction); 

            //modelBuilder.Entity<Team>()
            //    .HasMany(t => t.WinnerCupsRunnerUps)
            //    .WithOne(u => u.RunnerUp)
            //    .HasForeignKey(u => u.WinnersCupID)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity <Team>()
            //    .HasMany(t => t.UEFASuperCups)
            //    .WithOne(u => u.Winner)
            //    .HasForeignKey(u => u.UEFASuperCupID)
            //    .OnDelete (DeleteBehavior.NoAction);



            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.RunnerUp)
            //    .WithOne(b => b.RunnerUp)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.Winner)
            //    .WithOne(b => b.Winner)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.ThirdPlace)
            //    .WithOne(b => b.ThirdPlace)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.FourthPlace)
            //    .WithOne(b => b.FourthPlace)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.FifthPlace)
            //    .WithOne(b => b.Fifthlace)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.SixthPlace)
            //    .WithOne(b => b.SixthPlace)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.SeventhPlace)
            //    .WithOne(b => b.SeventhPlace)
            //     .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.EigthPlace)
            //    .WithOne(b => b.EigthPlace)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.NinethPlace)
            //    .WithOne(b => b.NinethPlace)
            //   .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.TenthPlace)
            //    .WithOne(b => b.TenthPlace)
            //    .HasForeignKey(b => b.BallonDorID)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Icon>()
            //    .HasMany(icon => icon.Nominations)
            //    .WithMany(b => b.Nominations);
           



            modelBuilder.Entity<Icon>()
                .HasOne(icon => icon.NationStats)
                .WithOne(nat => nat.Icon)
                .HasForeignKey<NationPlayerStats>(n =>  n.ID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Icon>()
                .HasMany(icon => icon.TeamStats)
                .WithOne(stat => stat.Icon)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            


        }
    }
}
