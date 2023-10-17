using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballIconsCAPI.Entities
{
    [Table("ChampionsCupInfo")]
    [PrimaryKey(nameof(ChampionsCupID))]
    public class ChampionsCup
    {
        public ChampionsCup() { }
        [Required]
        public int ChampionsCupID { get; set; }

        public string Winner { get; set; }
        public string RunnerUp { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
    }
}
