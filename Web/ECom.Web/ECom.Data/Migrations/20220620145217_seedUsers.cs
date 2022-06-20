using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECom.Web.Data.Migrations
{
    public partial class seedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a75caa2-88e6-43e0-90c9-e47d96becd21", "587575f7-ea6d-4882-a2b8-54a7c71ec3f7", "Admin", "ADMIN" },
                    { "2af27e81-088b-459a-9c1b-382ff2cba5b6", "7ecfe4ae-826a-4eff-9b29-584adc4fdd59", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "77b3cd96-0821-410b-a240-ce7f2a356d44", 0, "c7572e15-1e4c-40aa-b2c7-53b86c58859f", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEM8nPIsUG+wkHqdu0QXBE39scQ8cNq01Ls7Ksy1z6F7yr6Kr0CUhHsI2oDVAz0ZZw==", null, false, "ba159e3d-44f8-4b3b-9aa6-877e0a3a77e6", false, "admin@admin.com" },
                    { "f49467fd-3fdb-4d9f-8bff-f676f2606cd6", 0, "fe565f18-3566-4307-aa99-7a60756b314c", "employee@employee.com", true, false, null, "EMPLOYEE@EMPLOYEE.COM", "EMPLOYEE@EMPLOYEE.COM", "AQAAAAEAACcQAAAAELF69vE8nXUNAZdOYN5c17wrgOsMDZFyG7zO43DvsufN98RDXsm7oPsXzD/Pdmr5LQ==", null, false, "d28844de-e5fb-434d-998c-f5c38d818394", false, "employee@employee.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0a75caa2-88e6-43e0-90c9-e47d96becd21", "77b3cd96-0821-410b-a240-ce7f2a356d44" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2af27e81-088b-459a-9c1b-382ff2cba5b6", "f49467fd-3fdb-4d9f-8bff-f676f2606cd6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a75caa2-88e6-43e0-90c9-e47d96becd21", "77b3cd96-0821-410b-a240-ce7f2a356d44" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2af27e81-088b-459a-9c1b-382ff2cba5b6", "f49467fd-3fdb-4d9f-8bff-f676f2606cd6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a75caa2-88e6-43e0-90c9-e47d96becd21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2af27e81-088b-459a-9c1b-382ff2cba5b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77b3cd96-0821-410b-a240-ce7f2a356d44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f49467fd-3fdb-4d9f-8bff-f676f2606cd6");
        }
    }
}
