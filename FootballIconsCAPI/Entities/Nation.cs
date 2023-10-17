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
    }
}
