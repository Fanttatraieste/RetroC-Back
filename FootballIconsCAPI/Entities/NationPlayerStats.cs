using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("NationStatsInfo")]
    [PrimaryKey(nameof(NationStatID))]
    public class NationPlayerStats
    {
        public NationPlayerStats() { }
        [Required]
        public int IconID { get; set; }

        public int NationID { get; set; }

        [Required]
        [Key]
        public int NationStatID { get; set; }

        public int GamesPlayed { get; set; }

        public int GoalsScored { get; set; }

        public int WorldCupGoals { get; set; }

        public virtual ICollection<WorldCup>? WorldCupsTitles { get; set; }

        public virtual ICollection<WorldCup>? WorldCupRunnerUps { get; set; }

        public virtual ICollection<WorldCup>? WorldCupThirdPlaces { get; set; }

        public virtual ICollection<ContinentalCup>? ContinentalCupsTitles { get;  set; }
        public virtual ICollection<ContinentalCup>? ContinentalCupRunnerUps { get; set; }
        public virtual ICollection<ContinentalCup>? ContinentalCupThirdPlaces { get; set; }
    }
}
