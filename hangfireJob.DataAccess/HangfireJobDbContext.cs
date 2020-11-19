using System;
using Microsoft.EntityFrameworkCore;

namespace hangfireJob.DataAccess
{
    public class HangfireJobDbContext : DbContext
    {
        public HangfireJobDbContext(DbContextOptions<HangfireJobDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<LogData> LogDataTbl {get; set; }
    }
}
