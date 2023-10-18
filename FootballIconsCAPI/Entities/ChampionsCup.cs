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

        public int Winner { get; set; }

        //[ForeignKey("Winner")]
        //public Team WinnerTeam {  get; set; }

        public int RunnerUp { get; set; }

        //[ForeignKey("RunnerUp")]
        //public Team RunnerUpTeam { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
    }
}
