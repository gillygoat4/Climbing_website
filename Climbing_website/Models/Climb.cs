using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Climbing_website.Models
{
    public class Climb
    {
        public int Quantity { get; set; }
        public int Climbs_Points {  get; set; }

        //foreign for climbers
        [ForeignKey("Climber_ID")]
        public int Climber_ID {  get; set; }
        public Climber Climber { get; set; }
        //foreign for Types
        [ForeignKey("Type_ID")]
        public int Type_ID {  get; set; }
        public Type Type { get; set; }
    }

}
