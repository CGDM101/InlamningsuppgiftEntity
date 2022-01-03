using Microsoft.EntityFrameworkCore.Migrations;

namespace InlamningsuppgiftEntity.Migrations
{
    public partial class added_another_birthyeear_1962 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthYear",
                value: 1962);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthYear",
                value: 0);
        }
    }
}
