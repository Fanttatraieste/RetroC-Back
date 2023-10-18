using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballIconsCAPI.Entities
{
    [Table("DomesticSuperCupInfo")]
    [PrimaryKey(nameof(DomesticSuperCupID))]
    public class DomesticSuperCup
    {
        public DomesticSuperCup() { }
        [Required]
        public int DomesticSuperCupID { get; set; }

        public int Winner { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
    }
}
