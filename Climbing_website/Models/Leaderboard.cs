using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Climbing_website.Models
{
    public class Leaderboard
    {
        [Key]
        public int Position { get; set; }
        public int Total_Points { get; set; }

        [ForeignKey("Climber_ID")] 
        public int Climber_ID { get; set; }
        public Climber Climbers { get; set; }
    }
}
