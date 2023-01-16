using Alpha.Data.Configuration;
using Alpha.Models;
using Microsoft.EntityFrameworkCore;

namespace Alpha.Data {
    public class AlphaContext : DbContext {
        #nullable disable
        public AlphaContext(DbContextOptions options) : base(options) {
        }
        #nullable restore

        public DbSet<YearSummary> YearSummaries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new YearSummaryConfiguration());
        }

//      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
//          optionsBuilder.UseSqlServer(@"Data source=Alpha.db");
//      }
    }
}