using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tracker.Models;

namespace Tracker.Data
{
    public class TrackerOrderHistoryContext : DbContext
    {
        public TrackerOrderHistoryContext(DbContextOptions<TrackerOrderHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<TrackerOrderHistory> TrackerOrderHistory { get; set; }
    }
}
