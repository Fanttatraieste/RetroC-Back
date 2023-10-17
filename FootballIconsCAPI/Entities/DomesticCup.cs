using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballIconsCAPI.Entities
{
    [Table("DomesticCupInfo")]
    [PrimaryKey(nameof(DomesticCupID))]
    public class DomesticCup
    {
        public DomesticCup() { }
        [Required]
        public int DomesticCupID { get; set; }

        public string Winner { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
    }
}
