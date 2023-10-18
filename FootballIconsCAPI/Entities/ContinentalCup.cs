using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("ContinentalCupInfo")]
    [PrimaryKey(nameof(ContinentalCupID))]
    public class ContinentalCup
    {
        public ContinentalCup() { }
        [Required]
        public int ContinentalCupID { get; set; }

        public Nation Winner { get; set; }
        public Nation RunnerUp { get; set; }
        public Nation ThirdPlace { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
        public string CupName {  get; set; }
    }
}
