using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nguyenvankhoat591.Migrations
{
    public partial class Create_Table_CompanyNVK591 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyNVK591",
                columns: table => new
                {
                    CompanyId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyNVK591", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "NVK0591",
                columns: table => new
                {
                    NVKId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NVKName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NVKGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVK0591", x => x.NVKId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyNVK591");

            migrationBuilder.DropTable(
                name: "NVK0591");
        }
    }
}
