using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnowReport.Models;

namespace SnowReport.Data
{
    public class SnowReportContext : DbContext
    {
        public SnowReportContext(DbContextOptions<SnowReportContext> options) : base(options)
        {
        }

        public DbSet<SnowReport.Models.SnowTotals> SnowTotals { get; set; } = default!;
        public DbSet<UserFeedback> UserFeedbacks { get; set; }
    }

       
}

