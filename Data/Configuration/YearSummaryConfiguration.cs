using Alpha.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alpha.Data.Configuration {
    public class YearSummaryConfiguration : IEntityTypeConfiguration<YearSummary> {
        public void Configure(EntityTypeBuilder<YearSummary> builder) {
            builder.HasData(new List<YearSummary> {
                new YearSummary {
                    Year = "1956",
                    RegularSeasonRecord = "1-4-0",
                    FullSeasonRecord = "1-4-0",
                    HeadCoach = "Neal Frame"
                },
               new YearSummary {
                    Year = "1957",
                    RegularSeasonRecord = "4-3-0",
                    FullSeasonRecord = "4-3-0",
                    HeadCoach = "Neal Frame"
                },
               new YearSummary {
                    Year = "1958",
                    RegularSeasonRecord = "3-6-0",
                    FullSeasonRecord = "3-6-0",
                    League = "LBL",
                    HeadCoach = "Neal Frame"
                }
            });
        }
    }
}