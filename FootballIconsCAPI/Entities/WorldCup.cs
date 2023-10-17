using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("WorldCupInfo")]
    [PrimaryKey(nameof(WorldCupID))]
    public class WorldCup
    {
        public WorldCup() { }
        [Required]
        public int WorldCupID { get; set; }

        public string Winner { get; set; }
        public string RunnerUp {  get; set; }
        public string ThirdPlace { get; set; }
        public string Place {  get; set; }
        public int Year { get; set; }
    }
}
