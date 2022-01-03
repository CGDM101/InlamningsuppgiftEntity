using Microsoft.EntityFrameworkCore.Migrations;

namespace InlamningsuppgiftEntity.Migrations
{
    public partial class added_birthyear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "MyPeople",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthYear",
                value: 1962);

            migrationBuilder.UpdateData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthYear",
                value: 1999);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "MyPeople");
        }
    }
}
