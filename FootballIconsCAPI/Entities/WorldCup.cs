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

        public Nation Winner { get; set; }
        public Nation RunnerUp {  get; set; }
        public Nation ThirdPlace { get; set; }
        public string Place {  get; set; }
        public int Year { get; set; }
    }
}
