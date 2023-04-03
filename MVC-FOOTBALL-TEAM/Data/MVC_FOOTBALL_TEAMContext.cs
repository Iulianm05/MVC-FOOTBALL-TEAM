using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_FOOTBALL_TEAM.Models;

namespace MVC_FOOTBALL_TEAM.Data
{
    public class MVC_FOOTBALL_TEAMContext : DbContext
    {
        public MVC_FOOTBALL_TEAMContext (DbContextOptions<MVC_FOOTBALL_TEAMContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_FOOTBALL_TEAM.Models.Team> Team { get; set; } = default!;

        public DbSet<MVC_FOOTBALL_TEAM.Models.Player>? Player { get; set; }

        public DbSet<MVC_FOOTBALL_TEAM.Models.Coach>? Coach { get; set; }

        public DbSet<MVC_FOOTBALL_TEAM.Models.Stadium>? Stadium { get; set; }

    }
}
