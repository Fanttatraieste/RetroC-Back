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

        public string Winner { get; set; }
        public string RunnerUp { get; set; }
        public string ThirdPlace { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
        public string CupName {  get; set; }
    }
}
