using Learning.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Data
{
    public static class Seed
    {
        public static async Task Seeding(ApplicationDbContext context, UserManager<AppUser> userManager)
        {

            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser{ DisplayName="Sachin", Email="sachin@gmail.com", UserName="sachin", Bio="Test Bio"  },
                    new AppUser{ DisplayName="Virat", Email="virat@gmail.com", UserName="virat", Bio="Test Bio" }
                };
                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
            if (!context.Activities.Any())
            {
                await context.Activities.AddRangeAsync(ActivitySeeder.GenerateMockData());
                await context.SaveChangesAsync();
            }
            return;

        }
    }
}
