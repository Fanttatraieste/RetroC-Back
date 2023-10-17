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
    }
}
