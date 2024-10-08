using Climbing_website.Models;
using Microsoft.EntityFrameworkCore;

namespace Climbing_website.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Climber> Climbers { get; set; }
        public DbSet<Climb> Climbs { get; set; }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Leaderboard> Leaders { get; set; }
        public DbSet<Slab_Of_The_Week> Slabs { get; set; }

   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Climb>().HasKey( Climb => new
            {
                Climb.Type_ID,
                Climb.Climber_ID
            });
            modelBuilder.Entity<Climb>().HasOne(c1 => c1.Climber).WithMany(c2 => c2.Climbs).HasForeignKey(c1 => c1.Climber_ID);
            modelBuilder.Entity<Climb>().HasOne(T => T.Type).WithMany(c2 => c2.Climbs).HasForeignKey(T => T.Type_ID);
            base.OnModelCreating(modelBuilder);// dont need to define the identify manualy

        }
    }
        
}
