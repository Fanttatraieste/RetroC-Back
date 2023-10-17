using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("TeamStatsInfo")]
    [PrimaryKey(nameof(TeamStatID))]
    public class TeamPlayerStats
    {
        public TeamPlayerStats() { }
        [Required]
        public int IconID { get; set; }

        public Team Team { get; set; }

        [Required]
        [Key]
        public int TeamStatID { get; set; }

        public int GamesPlayed { get; set; }

        public int GoalsScored { get; set; }
        
        public ICollection<DomesticLeague>? DomesticLeagues { get;  set; }
        public ICollection<DomesticCup>? DomesticCups { get; set; }
        public ICollection<DomesticSuperCup>? DomesticSuperCups { get; set; }

        public ICollection<ChampionsCup>? ChampionsCups { get; set; }
        public ICollection<ChampionsCup>? ChampionsCupRunnerUps { get; set; }
        public ICollection<UEFACup>? UEFACups { get; set; }
        public ICollection<UEFACup>? UEFACupRunnerUps { get; set; }

        public ICollection<WinnersCup>?  WinnersCups { get; set;}

        public ICollection<WinnersCup>? WinnersCupRunnersUp { get; set; }

        public ICollection<UEFASuperCup>? UEFASuperCups { get;set; }

    }
}
