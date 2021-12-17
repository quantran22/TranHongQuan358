using Microsoft.EntityFrameworkCore.Migrations;

namespace TranHongQuan358.Migrations
{
    public partial class UniversityTHQ358 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityTHQ358s",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityTHQ358s", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityTHQ358s");
        }
    }
}
