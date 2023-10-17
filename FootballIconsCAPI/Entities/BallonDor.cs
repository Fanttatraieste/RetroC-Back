using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("BallonDorInfo")]
    [PrimaryKey(nameof(BallonDorID))]
    public class BallonDor
    {
        public BallonDor () { }
        [Required]
        public int BallonDorID { get; set; }

        public int Year { get; set; }

        public Icon Winner { get; set; }

        public ICollection<Icon> RunnerUp {  get; set; }
        public ICollection<Icon> ThirdPlace { get; set; }

        public ICollection<Icon> FourthPlace { get; set; }
        public ICollection<Icon> Fifthlace { get; set; }
        public ICollection<Icon> SixthPlace { get; set; }
        public ICollection<Icon> SeventhPlace { get; set; }
        public ICollection<Icon> EigthPlace { get; set; }
        public ICollection<Icon> NinethPlace { get; set; }
        public ICollection<Icon> TenthPlace { get; set; }
        public ICollection<Icon> Nominations { get; set; }
    }
}
