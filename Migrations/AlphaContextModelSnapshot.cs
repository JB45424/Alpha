// <auto-generated />
using Alpha.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alpha.Migrations
{
    [DbContext(typeof(AlphaContext))]
    partial class AlphaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Alpha.Models.YearSummary", b =>
                {
                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullSeasonRecord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadCoach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("League")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeagueRecord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostSeasonRecord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegularSeasonRecord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Year");

                    b.ToTable("YearSummaries");

                    b.HasData(
                        new
                        {
                            Year = "1956",
                            FullSeasonRecord = "1-4-0",
                            HeadCoach = "Neal Frame",
                            RegularSeasonRecord = "1-4-0"
                        },
                        new
                        {
                            Year = "1957",
                            FullSeasonRecord = "4-3-0",
                            HeadCoach = "Neal Frame",
                            RegularSeasonRecord = "4-3-0"
                        },
                        new
                        {
                            Year = "1958",
                            FullSeasonRecord = "3-6-0",
                            HeadCoach = "Neal Frame",
                            League = "LBL",
                            RegularSeasonRecord = "3-6-0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
