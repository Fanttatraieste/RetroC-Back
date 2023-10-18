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

        [ForeignKey(nameof(Icon))]
        public Icon Winner { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon RunnerUp {  get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon ThirdPlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon FourthPlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon Fifthlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon SixthPlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon SeventhPlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon EigthPlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon NinethPlace { get; set; }

        [ForeignKey(nameof(Icon))]
        public Icon TenthPlace { get; set; }
        public ICollection<Icon> Nominations { get; set; }
    }
}
