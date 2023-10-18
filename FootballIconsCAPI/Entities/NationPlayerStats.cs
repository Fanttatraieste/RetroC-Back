using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("NationStatsInfo")]
    [PrimaryKey(nameof(ID))]
    public class NationPlayerStats
    {
        public NationPlayerStats() { }
        [Required]
        public Icon Icon { get; set; }

        public Nation Nation { get; set; }

        [Required]
        [Key]
        public int ID { get; set; }

        public int GamesPlayed { get; set; }

        public int GoalsScored { get; set; }

        public int WorldCupGoals { get; set; }

        //public virtual ICollection<WorldCup>? WorldCupsTitles { get; set; }

        //public virtual ICollection<WorldCup>? WorldCupRunnerUps { get; set; }

        //public virtual ICollection<WorldCup>? WorldCupThirdPlaces { get; set; }

        //public virtual ICollection<ContinentalCup>? ContinentalCupsTitles { get;  set; }
        //public virtual ICollection<ContinentalCup>? ContinentalCupRunnerUps { get; set; }
        //public virtual ICollection<ContinentalCup>? ContinentalCupThirdPlaces { get; set; }
    }
}
