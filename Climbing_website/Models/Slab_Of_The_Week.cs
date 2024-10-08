using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Climbing_website.Models
{
    public class Slab_Of_The_Week
    {
        [Key] 
        public int slab_ID { get; set; }
        //foreign key for climber
        [ForeignKey("Climber_ID")]
        public int Climber_ID { get; set; }
        public Climber Climbers { get; set; }
        public DateOnly Date {  get; set; }
        public bool Flashed { get; set; }
        public int Points {  get; set; }


    }
}
