using Microsoft.EntityFrameworkCore.Migrations;

namespace TranHongQuan358.Migrations
{
    public partial class THQ358 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "THQ358",
                columns: table => new
                {
                    THQId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    THQName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    THQGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THQ358", x => x.THQId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "THQ358");
        }
    }
}
