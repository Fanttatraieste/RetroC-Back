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

  
        public int Winner { get; set; }

     
        public int RunnerUp {  get; set; }

     
        public int ThirdPlace { get; set; }

      
        public int FourthPlace { get; set; }

     
        public int Fifthlace { get; set; }

    
        public int SixthPlace { get; set; }

     
        public int SeventhPlace { get; set; }

       
        public int EigthPlace { get; set; }

      
        public int NinethPlace { get; set; }

       
        public int TenthPlace { get; set; }
        public ICollection<int> Nominations { get; set; }
    }
}
