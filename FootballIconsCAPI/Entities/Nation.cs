using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FootballIconsCAPI.Entities
{
    [Table("NationInfo")]
    [PrimaryKey(nameof(NationID))]
    public class Nation
    {
        public Nation() { }

        [Key]
        public int NationID {  get; set; }

        [Column("Name")]
        [MaxLength(50)]
        [MinLength(4)]
        [Required]
        [Key]
        public string NationName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Confederation {  get; set; }

        public ICollection<WorldCup>? WorldCups {  get; set; }
        public ICollection<WorldCup>? WorldCupsRunnerUps {  get; set; }
        public ICollection<WorldCup>? WorldCupThirdPlace { get; set; }

        public ICollection<ContinentalCup>? ContinentalCups { get; set; }
        public ICollection<ContinentalCup>? ContinentalCupsRunnerUps { get; set; }
        public ICollection<ContinentalCup>? ContinentalCupsThirdPlace {  get; set; }

    }
}
