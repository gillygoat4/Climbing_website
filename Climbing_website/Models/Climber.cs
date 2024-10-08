using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Climbing_website.Data.Enumb;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace Climbing_website.Models
{
    public class Climber
    {
        [Key] public int Climber_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; } 
        public Gender_Option Gender { get; set; }
        public int Age { get; set; }
        public DateOnly Date_joined { get; set; }

        //public Leaderboard Leaderboards { get; set; }
        //other table relations
        public List<Climb> Climbs  { get; set; }
        public List<Slab_Of_The_Week> Slabs { get; set; }
    }

}

