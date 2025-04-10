using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class seedningDataMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AdminUsers",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsActive", "LastLoginAt", "PasswordHash", "PhoneNumber", "ProfileImageUrl", "Role", "Username" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2@example.com", "Admin User 2", true, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_2", "1234567802", null, "Manager", "admin2" },
                    { 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin3@example.com", "Admin User 3", true, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_3", "1234567803", null, "SuperAdmin", "admin3" },
                    { 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin4@example.com", "Admin User 4", true, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_4", "1234567804", null, "Manager", "admin4" },
                    { 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin5@example.com", "Admin User 5", true, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_5", "1234567805", null, "SuperAdmin", "admin5" },
                    { 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin6@example.com", "Admin User 6", true, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_6", "1234567806", null, "Manager", "admin6" },
                    { 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin7@example.com", "Admin User 7", true, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_7", "1234567807", null, "SuperAdmin", "admin7" },
                    { 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin8@example.com", "Admin User 8", true, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_8", "1234567808", null, "Manager", "admin8" },
                    { 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin9@example.com", "Admin User 9", true, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_9", "1234567809", null, "SuperAdmin", "admin9" },
                    { 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin10@example.com", "Admin User 10", true, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_10", "1234567810", null, "Manager", "admin10" },
                    { 11, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin11@example.com", "Admin User 11", true, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_11", "1234567811", null, "SuperAdmin", "admin11" },
                    { 12, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin12@example.com", "Admin User 12", true, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_12", "1234567812", null, "Manager", "admin12" },
                    { 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin13@example.com", "Admin User 13", true, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_13", "1234567813", null, "SuperAdmin", "admin13" },
                    { 14, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin14@example.com", "Admin User 14", true, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_14", "1234567814", null, "Manager", "admin14" },
                    { 15, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin15@example.com", "Admin User 15", true, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_15", "1234567815", null, "SuperAdmin", "admin15" },
                    { 16, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin16@example.com", "Admin User 16", true, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_16", "1234567816", null, "Manager", "admin16" },
                    { 17, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin17@example.com", "Admin User 17", true, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_17", "1234567817", null, "SuperAdmin", "admin17" },
                    { 18, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin18@example.com", "Admin User 18", true, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_18", "1234567818", null, "Manager", "admin18" },
                    { 19, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin19@example.com", "Admin User 19", true, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_19", "1234567819", null, "SuperAdmin", "admin19" },
                    { 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin20@example.com", "Admin User 20", true, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_20", "1234567820", null, "Manager", "admin20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
