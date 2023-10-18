using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballIconsCAPI.Entities
{
    [Table("TeamInfo")]
    [PrimaryKey(nameof(TeamID))]
    public class Team
    {
        public Team() { }

        [Key]
        public int TeamID { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        [MinLength(4)]
        [Required]
        [Key]
        public string TeamName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Country { get; set; }

        public ICollection<ChampionsCup>? ChampionsCupWinner { get; set; }
        public ICollection<ChampionsCup>? ChampionsCupRunnerUp {  get; set; }
        public ICollection<DomesticCup>? DomesticCups { get; set; }
        public ICollection<DomesticLeague>? DomestiLeagues {  get; set; }
        public ICollection<DomesticSuperCup>? DomesticSuperCups { get; set; }
        public ICollection<UEFACup>? UEFACups { get; set; }
        public ICollection<UEFACup>? UEFACupsRunnerUps { get; set; }

        public ICollection<WinnersCup>? WinnersCups { get; set;}
        public ICollection<WinnersCup>? WinnerCupsRunnerUps { get; set; }
        public ICollection<UEFASuperCup>? UEFASuperCups { get; set; }
    }
}
