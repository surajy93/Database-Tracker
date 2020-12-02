using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tracker.Models;

namespace Tracker.Data
{
    public class Sim_InfoContext : DbContext
    {
        public Sim_InfoContext(DbContextOptions<Sim_InfoContext> options)
            : base(options)
        {
        }

        public DbSet<Sim_Info> Sim_Info { get; set; }
    }
}
