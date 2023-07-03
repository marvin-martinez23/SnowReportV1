using Microsoft.EntityFrameworkCore;

namespace SnowReport.Models
{
    public class SnowReportDbContext : DbContext
    {
        public SnowReportDbContext(DbContextOptions<SnowReportDbContext> options) : base(options)
        {
        }

        public DbSet<SnowTotals> SnowTotals { get; set; }
        public DbSet<UserFeedback> UserFeedbacks { get; set; }
    }
}

