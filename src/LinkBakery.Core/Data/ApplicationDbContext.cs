using LinkBakery.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkBakery.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        public DbSet<TrackingLink> TrackingLinks { get; set; }
        public DbSet<TrackingLinkCall> TrackingLinkCalls { get; set; }
    }
}
