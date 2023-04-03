using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_FOOTBALL_TEAM.Data;
using System;
using System.Linq;

namespace MVC_FOOTBALL_TEAM.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVC_FOOTBALL_TEAMContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVC_FOOTBALL_TEAMContext>>()))
        {
            // Look for any movies.
            if (context.Team.Any())
            {
                return;   // DB has been seeded
            }
            context.Team.AddRange(
                new Team
                {
                    Name = "Real Madrid",
                    Date_of_establishment = DateTime.Parse("1989-2-12"),
                    Competition = "La Liga",
                    Transfer_budget = 7000000000
                },
                new Team
                {
                    Name = "Barcelona",
                    Date_of_establishment = DateTime.Parse("1989-2-12"),
                    Competition = "La Liga",
                    Transfer_budget = 732000000
                },
                new Team
                {
                    Name = "FCSB",
                    Date_of_establishment = DateTime.Parse("1989-2-12"),
                    Competition = "Superliga",
                    Transfer_budget = 7000000
                },
                new Team
                {
                    Name = "Liverpool",
                    Date_of_establishment = DateTime.Parse("1989-2-12"),
                    Competition = "Premier League",
                    Transfer_budget = 700000000
                }
            );
            context.SaveChanges();

        }
    }
}