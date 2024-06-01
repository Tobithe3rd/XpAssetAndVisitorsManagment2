using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace XpAssetAndVisitorsManagement.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0251c66c-f382-46e8-b7bc-5e644aff31b0", "1", "Super Admin", "Super Admin" },
                    { "6ac42e7d-e162-4dd5-a3b0-d78d589cdcb8", "2", "Admin", "Admin" },
                    { "d631c239-15ac-4ba3-97d9-df016cea7f01", "3", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0251c66c-f382-46e8-b7bc-5e644aff31b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ac42e7d-e162-4dd5-a3b0-d78d589cdcb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d631c239-15ac-4ba3-97d9-df016cea7f01");
        }
    }
}
