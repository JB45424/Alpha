using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alpha.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YearSummaries",
                columns: table => new
                {
                    Year = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LeagueRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularSeasonRecord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostSeasonRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullSeasonRecord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    League = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadCoach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearSummaries", x => x.Year);
                });

            migrationBuilder.InsertData(
                table: "YearSummaries",
                columns: new[] { "Year", "FullSeasonRecord", "HeadCoach", "League", "LeagueRecord", "Notes", "PostSeasonRecord", "RegularSeasonRecord" },
                values: new object[] { "1956", "1-4-0", "Neal Frame", null, null, null, null, "1-4-0" });

            migrationBuilder.InsertData(
                table: "YearSummaries",
                columns: new[] { "Year", "FullSeasonRecord", "HeadCoach", "League", "LeagueRecord", "Notes", "PostSeasonRecord", "RegularSeasonRecord" },
                values: new object[] { "1957", "4-3-0", "Neal Frame", null, null, null, null, "4-3-0" });

            migrationBuilder.InsertData(
                table: "YearSummaries",
                columns: new[] { "Year", "FullSeasonRecord", "HeadCoach", "League", "LeagueRecord", "Notes", "PostSeasonRecord", "RegularSeasonRecord" },
                values: new object[] { "1958", "3-6-0", "Neal Frame", "LBL", null, null, null, "3-6-0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YearSummaries");
        }
    }
}
