using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_FOOTBALL_TEAM.Data;
using System;
using System.Linq;

namespace MVC_FOOTBALL_TEAM.Models;

public static class SeedData2
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVC_FOOTBALL_TEAMContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVC_FOOTBALL_TEAMContext>>()))
        {
            // Look for any movies.
            if (context.Player.Any())
            {
                return;   // DB has been seeded
            }
            context.Player.AddRange(
                new Player
                {
                    FirstName = "Lionel",
                    LastName = "Messi",
                    BirthDate = DateTime.Parse("1989-2-12"),
                    Position = "Left Winger/Striker",
                    Value = 232427.99M
                },
                new Player
                {
                    FirstName = "Cristiano",
                    LastName = "Ronaldo",
                    BirthDate = DateTime.Parse("1989-2-12"),
                    Position = "Left Winger",
                    Value = 232427.99M
                },
               new Player
               {
                   FirstName = "Killian",
                   LastName = "Mbappe",
                   BirthDate = DateTime.Parse("1989-2-12"),
                   Position = "Striker",
                   Value = 32427.99M
               },
                new Player
                {
                    FirstName = "Virgil",
                    LastName = "Van-Dijk",
                    BirthDate = DateTime.Parse("1989-2-12"),
                    Position = "Center Defender",
                    Value = 3564227.99M
                }
            );
            context.SaveChanges();

        }
    }
}