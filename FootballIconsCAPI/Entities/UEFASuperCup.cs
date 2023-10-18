using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballIconsCAPI.Entities
{
    [Table("UEFASuperCupInfo")]
    [PrimaryKey(nameof(UEFASuperCupID))]
    public class UEFASuperCup
    {
        public UEFASuperCup() { }
        [Required]
        public int UEFASuperCupID { get; set; }

        public Team Winner { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
    }
}
