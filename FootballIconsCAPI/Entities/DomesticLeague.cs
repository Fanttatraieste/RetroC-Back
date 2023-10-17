using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("DomesticLeagueCupInfo")]
    [PrimaryKey(nameof(DomesticLeagueID))]
    public class DomesticLeague
    {
        public DomesticLeague() { }
        [Required]
        public int DomesticLeagueID { get; set; }

        public string Winner { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
    }
}
