using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_FOOTBALL_TEAM.Data;
using System;
using System.Linq;

namespace MVC_FOOTBALL_TEAM.Models;

public static class SeedData3
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVC_FOOTBALL_TEAMContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVC_FOOTBALL_TEAMContext>>()))
        {
            // Look for any movies.
            if (context.Coach.Any())
            {
                return;   // DB has been seeded
            }
            context.Coach.AddRange(
                new Coach
                {
                    FirstName = "Carlo",
                    LastName = "Ancelotti",
                    BirthDate = DateTime.Parse("1969-2-12"),
                    Team = "Real Madrid",
                    Tactic = "Offensive",
                    PointsPerMatch = 1.8M
                },
                new Coach
                {
                    FirstName = "Xavi",
                    LastName = "Hernandez",
                    BirthDate = DateTime.Parse("1980-2-12"),
                    Team = "Barcelona",
                    Tactic = "Tiki Taka",
                    PointsPerMatch = 2M
                },
               new Coach
               {
                   FirstName = "Jurgen",
                   LastName = "Klopp",
                   BirthDate = DateTime.Parse("1981-3-12"),
                   Team = "Liverpool",
                   Tactic = "Tiki Taka",
                   PointsPerMatch = 1.9M
               },
                new Coach
                {
                    FirstName = "Pep",
                    LastName = "Guardiola",
                    BirthDate = DateTime.Parse("1975-5-11"),
                    Team = "Manchester City",
                    Tactic = "Tiki Taka",
                    PointsPerMatch = 2.1M
                }
            );
            context.SaveChanges();

        }
    }
}