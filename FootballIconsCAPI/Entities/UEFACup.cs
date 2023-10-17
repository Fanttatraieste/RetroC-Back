using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("UEFACupInfo")]
    [PrimaryKey(nameof(UEFACupID))]
    public class UEFACup
    {
    public UEFACup() { }
        [Required]
        public int UEFACupID { get; set; }

        public string Winner { get; set; }
        public string RunnerUp { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
    }
}
