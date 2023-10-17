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

    }
}
