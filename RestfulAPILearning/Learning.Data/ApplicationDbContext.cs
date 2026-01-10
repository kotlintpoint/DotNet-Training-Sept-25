using Learning.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Learning.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Activity> Activities { get; set; }
        

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Activity>().HasData(
                 new Activity
                 {
                     Id = Guid.NewGuid(),
                     Title = "Hiking Trip",
                     Date = new DateTime(2026, 2, 15, 9, 0, 0),
                     Description = "A scenic hike through the mountains.",
                     Category = "Outdoors",
                     City = "Denver",
                     Venue = "Rocky Mountain National Park"
                 },
                 new Activity
                 {
                     Id = Guid.NewGuid(),
                     Title = "Tech Conference",
                     Date = new DateTime(2026, 3, 10, 10, 0, 0),
                     Description = "Annual conference on emerging technologies.",
                     Category = "Technology",
                     City = "San Francisco",
                     Venue = "Moscone Center"
                 },
                 new Activity
                 {
                     Id = Guid.NewGuid(),
                     Title = "Jazz Concert",
                     Date = new DateTime(2026, 4, 5, 19, 30, 0),
                     Description = "Live jazz performance by local artists.",
                     Category = "Music",
                     City = "New Orleans",
                     Venue = "French Quarter Theater"
                 },
                 new Activity
                 {
                     Id = Guid.NewGuid(),
                     Title = "Art Exhibition",
                     Date = new DateTime(2026, 5, 20, 11, 0, 0),
                     Description = "Modern art exhibition featuring international artists.",
                     Category = "Art",
                     City = "New York",
                     Venue = "Metropolitan Museum of Art"
                 }
             );

        }*/
    }
}
