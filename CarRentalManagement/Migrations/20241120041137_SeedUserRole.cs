using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "479d460d-b234-40d0-a09c-00cb3d94b6b9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBE2/HJy3345lYIZ6ymVof8ZKQTd2+dVEmAcBQFE6QMK67evx6Q9nJnYzG4Uwd6GyA==", null, false, "be8f9496-9310-4f69-bacf-d2c3c0014480", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7274), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7280), new DateTime(2024, 11, 20, 12, 11, 36, 690, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2228), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2491), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2596), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2599), new DateTime(2024, 11, 20, 11, 24, 7, 991, DateTimeKind.Local).AddTicks(2599) });
        }
    }
}
