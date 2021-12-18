using Microsoft.EntityFrameworkCore.Migrations;

namespace InlamningsuppgiftEntity.Migrations
{
    public partial class newTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyRelatives",
                columns: table => new
                {
                    DatabaseName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaxRows = table.Column<int>(type: "int", nullable: false),
                    OrderBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyRelatives", x => x.DatabaseName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyRelatives");
        }
    }
}
