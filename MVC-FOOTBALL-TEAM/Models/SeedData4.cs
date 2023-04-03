using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_FOOTBALL_TEAM.Data;
using System;
using System.Linq;

namespace MVC_FOOTBALL_TEAM.Models;

public static class SeedData4
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVC_FOOTBALL_TEAMContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVC_FOOTBALL_TEAMContext>>()))
        {
            // Look for any movies.
            if (context.Stadium.Any())
            {
                return;   // DB has been seeded
            }
            context.Stadium.AddRange(
                new Stadium
                {
                    Name = "Arena Nationala",
                    FoundationDate = DateTime.Parse("1969-2-12"),
                    Location = "Bucuresti",
                    Team = "-",
                    MaxAttendance = 56000
                },
                 new Stadium
                 {
                     Name = "Camp Nou",
                     FoundationDate = DateTime.Parse("1929-2-12"),
                     Location = "Barcelona",
                     Team = "Bucuresti",
                     MaxAttendance = 96000
                 },
               new Stadium
               {
                   Name = "Santago Bernabeu",
                   FoundationDate = DateTime.Parse("1929-2-12"),
                   Location = "Madrid",
                   Team = "Real Madrid",
                   MaxAttendance = 92000
               },
               new Stadium
               {
                   Name = "Anfield",
                   FoundationDate = DateTime.Parse("1929-4-12"),
                   Location = "Liverpool",
                   Team = "Fc Liverpool",
                   MaxAttendance = 58000
               }
            );
            context.SaveChanges();

        }
    }
}