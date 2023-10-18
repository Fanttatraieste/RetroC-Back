using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballIconsCAPI.Entities
{
    [Table("IconInfo")]
    [PrimaryKey(nameof(IconID))]
    public class Icon
    {
        public Icon() { }
        public int IconID { get; set; }
        public string Name { get; set; }
        public DateTime DoB {  get; set; }

        public int CareerLength { get; set; }
        public int CareerGames {get; set; }

        public int CareerGoals { get; set; }

        public int Fantascore { get; set; }

        public string Position {  get; set; }

        public NationPlayerStats NationStats { get; set; }

        public ICollection<TeamPlayerStats> TeamStats { get; set; }


        //public ICollection<BallonDor>? Winner {  get; set; }
        //public ICollection<BallonDor>? RunnerUp { get; set; }
        //public ICollection<BallonDor>? ThirdPlace { get; set; }
        //public ICollection<BallonDor>? FourthPlace { get; set; }
        //public ICollection<BallonDor>? FifthPlace { get; set; }
        //public ICollection<BallonDor>? SixthPlace { get; set; }
        //public ICollection<BallonDor>? SeventhPlace { get; set; }
        //public ICollection<BallonDor>? EigthPlace { get; set; }
        //public ICollection<BallonDor>? NinethPlace { get; set; }
        //public ICollection<BallonDor>? TenthPlace { get; set; }
        //public ICollection<BallonDor>? Nominations { get; set; }
    }
}
