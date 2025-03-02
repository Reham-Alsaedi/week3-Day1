using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeMangment.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "John Doe", "Manager", 60000m },
                    { 2, "Jane Smith", "Developer", 50000m },
                    { 3, "Alice Johnson", "Designer", 55000m },
                    { 4, "Bob Brown", "Tester", 40000m },
                    { 5, "Charlie Davis", "Developer", 52000m },
                    { 6, "David Lee", "Manager", 65000m },
                    { 7, "Eva Clark", "Developer", 48000m },
                    { 8, "Frank Moore", "Sales", 45000m },
                    { 9, "Grace Taylor", "HR", 46000m },
                    { 10, "Helen Harris", "Support", 42000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
