using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class seedningData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastLoginAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastLoginAt" },
                values: new object[] { new DateTime(2025, 4, 9, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9089), new DateTime(2025, 4, 10, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9235) });

            migrationBuilder.InsertData(
                table: "AdminUsers",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsActive", "LastLoginAt", "PasswordHash", "PhoneNumber", "ProfileImageUrl", "Role", "Username" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 4, 8, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9519), "admin2@example.com", "Admin User 2", true, new DateTime(2025, 4, 9, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9519), "hashed_password_2", "1234567802", null, "Manager", "admin2" },
                    { 3, new DateTime(2025, 4, 7, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9525), "admin3@example.com", "Admin User 3", true, new DateTime(2025, 4, 9, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9525), "hashed_password_3", "1234567803", null, "SuperAdmin", "admin3" },
                    { 4, new DateTime(2025, 4, 6, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9529), "admin4@example.com", "Admin User 4", true, new DateTime(2025, 4, 8, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9529), "hashed_password_4", "1234567804", null, "Manager", "admin4" },
                    { 5, new DateTime(2025, 4, 5, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9537), "admin5@example.com", "Admin User 5", true, new DateTime(2025, 4, 8, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9538), "hashed_password_5", "1234567805", null, "SuperAdmin", "admin5" },
                    { 6, new DateTime(2025, 4, 4, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9548), "admin6@example.com", "Admin User 6", true, new DateTime(2025, 4, 7, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9548), "hashed_password_6", "1234567806", null, "Manager", "admin6" },
                    { 7, new DateTime(2025, 4, 3, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9579), "admin7@example.com", "Admin User 7", true, new DateTime(2025, 4, 7, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9579), "hashed_password_7", "1234567807", null, "SuperAdmin", "admin7" },
                    { 8, new DateTime(2025, 4, 2, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9585), "admin8@example.com", "Admin User 8", true, new DateTime(2025, 4, 6, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9585), "hashed_password_8", "1234567808", null, "Manager", "admin8" },
                    { 9, new DateTime(2025, 4, 1, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9588), "admin9@example.com", "Admin User 9", true, new DateTime(2025, 4, 6, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9588), "hashed_password_9", "1234567809", null, "SuperAdmin", "admin9" },
                    { 10, new DateTime(2025, 3, 31, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9595), "admin10@example.com", "Admin User 10", true, new DateTime(2025, 4, 5, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9595), "hashed_password_10", "1234567810", null, "Manager", "admin10" },
                    { 11, new DateTime(2025, 3, 30, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9598), "admin11@example.com", "Admin User 11", true, new DateTime(2025, 4, 5, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9598), "hashed_password_11", "1234567811", null, "SuperAdmin", "admin11" },
                    { 12, new DateTime(2025, 3, 29, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9601), "admin12@example.com", "Admin User 12", true, new DateTime(2025, 4, 4, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9601), "hashed_password_12", "1234567812", null, "Manager", "admin12" },
                    { 13, new DateTime(2025, 3, 28, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9604), "admin13@example.com", "Admin User 13", true, new DateTime(2025, 4, 4, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9604), "hashed_password_13", "1234567813", null, "SuperAdmin", "admin13" },
                    { 14, new DateTime(2025, 3, 27, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9607), "admin14@example.com", "Admin User 14", true, new DateTime(2025, 4, 3, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9607), "hashed_password_14", "1234567814", null, "Manager", "admin14" },
                    { 15, new DateTime(2025, 3, 26, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9609), "admin15@example.com", "Admin User 15", true, new DateTime(2025, 4, 3, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9610), "hashed_password_15", "1234567815", null, "SuperAdmin", "admin15" },
                    { 16, new DateTime(2025, 3, 25, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9613), "admin16@example.com", "Admin User 16", true, new DateTime(2025, 4, 2, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9614), "hashed_password_16", "1234567816", null, "Manager", "admin16" },
                    { 17, new DateTime(2025, 3, 24, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9616), "admin17@example.com", "Admin User 17", true, new DateTime(2025, 4, 2, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9616), "hashed_password_17", "1234567817", null, "SuperAdmin", "admin17" },
                    { 18, new DateTime(2025, 3, 23, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9620), "admin18@example.com", "Admin User 18", true, new DateTime(2025, 4, 1, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9620), "hashed_password_18", "1234567818", null, "Manager", "admin18" },
                    { 19, new DateTime(2025, 3, 22, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9623), "admin19@example.com", "Admin User 19", true, new DateTime(2025, 4, 1, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9623), "hashed_password_19", "1234567819", null, "SuperAdmin", "admin19" },
                    { 20, new DateTime(2025, 3, 21, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9626), "admin20@example.com", "Admin User 20", true, new DateTime(2025, 3, 31, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9626), "hashed_password_20", "1234567820", null, "Manager", "admin20" },
                    { 21, new DateTime(2025, 3, 20, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9629), "admin21@example.com", "Admin User 21", true, new DateTime(2025, 3, 31, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9629), "hashed_password_21", "1234567821", null, "SuperAdmin", "admin21" },
                    { 22, new DateTime(2025, 3, 19, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9631), "admin22@example.com", "Admin User 22", true, new DateTime(2025, 3, 30, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9632), "hashed_password_22", "1234567822", null, "Manager", "admin22" },
                    { 23, new DateTime(2025, 3, 18, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9634), "admin23@example.com", "Admin User 23", true, new DateTime(2025, 3, 30, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9635), "hashed_password_23", "1234567823", null, "SuperAdmin", "admin23" },
                    { 24, new DateTime(2025, 3, 17, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9637), "admin24@example.com", "Admin User 24", true, new DateTime(2025, 3, 29, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9637), "hashed_password_24", "1234567824", null, "Manager", "admin24" },
                    { 25, new DateTime(2025, 3, 16, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9640), "admin25@example.com", "Admin User 25", true, new DateTime(2025, 3, 29, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9640), "hashed_password_25", "1234567825", null, "SuperAdmin", "admin25" },
                    { 26, new DateTime(2025, 3, 15, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9643), "admin26@example.com", "Admin User 26", true, new DateTime(2025, 3, 28, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9643), "hashed_password_26", "1234567826", null, "Manager", "admin26" },
                    { 27, new DateTime(2025, 3, 14, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9646), "admin27@example.com", "Admin User 27", true, new DateTime(2025, 3, 28, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9646), "hashed_password_27", "1234567827", null, "SuperAdmin", "admin27" },
                    { 28, new DateTime(2025, 3, 13, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9689), "admin28@example.com", "Admin User 28", true, new DateTime(2025, 3, 27, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9689), "hashed_password_28", "1234567828", null, "Manager", "admin28" },
                    { 29, new DateTime(2025, 3, 12, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9692), "admin29@example.com", "Admin User 29", true, new DateTime(2025, 3, 27, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9692), "hashed_password_29", "1234567829", null, "SuperAdmin", "admin29" },
                    { 30, new DateTime(2025, 3, 11, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9695), "admin30@example.com", "Admin User 30", true, new DateTime(2025, 3, 26, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9695), "hashed_password_30", "1234567830", null, "Manager", "admin30" }
                });
        }
    }
}
