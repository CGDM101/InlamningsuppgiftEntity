using Microsoft.EntityFrameworkCore.Migrations;

namespace InlamningsuppgiftEntity.Migrations
{
    public partial class added_people : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MyPeople",
                columns: new[] { "Id", "Far", "LastName", "Mor", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Gahan", 2, "Dave" },
                    { 2, 0, "Gahan", 0, "Sylvia" },
                    { 3, 0, "Gahan", 0, "Len" },
                    { 4, 3, "Gahan", 2, "Sue" },
                    { 5, 7, "Gahan", 2, "Peter" },
                    { 6, 7, "Gahan", 2, "Phil" },
                    { 7, 0, "Gahan", 0, "Jack" },
                    { 8, 1, "Gahan", 9, "Jack" },
                    { 9, 0, "Fox", 0, "Joanne" },
                    { 10, 1, "Gahan", 11, "Stella Rose" },
                    { 11, 0, "Sklias-Gahan", 12, "Jennifer" },
                    { 12, 0, "Sklias", 0, "Stella" },
                    { 13, 0, "Rogers-Gahan", 11, "Jimmy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MyPeople",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
