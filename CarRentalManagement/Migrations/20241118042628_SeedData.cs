using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7436), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7440), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7671), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7675), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7785), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7787), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7790), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7792), new DateTime(2024, 11, 18, 12, 26, 27, 230, DateTimeKind.Local).AddTicks(7792), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
