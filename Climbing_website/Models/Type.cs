using System.ComponentModel.DataAnnotations;

namespace Climbing_website.Models
{
    public class Type
    {
        [Key] public int Type_ID { get; set; }
        public int CLimbType { get; set; }
        public int Climbworth { get; set; }
        //other table relations
        public List<Climb> Climbs { get; set; }
    }
}
