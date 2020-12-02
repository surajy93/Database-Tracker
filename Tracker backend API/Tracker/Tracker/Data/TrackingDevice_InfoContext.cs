using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tracker.Models;

namespace Tracker.Data
{
    public class TrackingDevice_InfoContext : DbContext
    {
        public TrackingDevice_InfoContext(DbContextOptions<TrackingDevice_InfoContext> options)
            : base(options)
        {
        }

        public DbSet<TrackingDevice_Info> TrackingDevice_Info { get; set; }
    }
}
