using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECom.Web.Data.Migrations
{
    public partial class statusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77b3cd96-0821-410b-a240-ce7f2a356d44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ae088b5-f7c2-44ec-9191-be5f31d0b015", "AQAAAAEAACcQAAAAENyOMjH5u3pcn/izZfrYBD1yONNJbxOxoEHz98bMDMeqGr3U8bnrt/zXgqS31YzCVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f49467fd-3fdb-4d9f-8bff-f676f2606cd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1dff5ff-4b69-4a55-ad7a-ec436afa0594", "AQAAAAEAACcQAAAAENVC3ct7qvMXskSSIDFs+LKC3q3LTGfFkMK8fZwGpSjE6N6HBDn0v4StPJ+nzVnLEA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77b3cd96-0821-410b-a240-ce7f2a356d44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7572e15-1e4c-40aa-b2c7-53b86c58859f", "AQAAAAEAACcQAAAAEEM8nPIsUG+wkHqdu0QXBE39scQ8cNq01Ls7Ksy1z6F7yr6Kr0CUhHsI2oDVAz0ZZw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f49467fd-3fdb-4d9f-8bff-f676f2606cd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe565f18-3566-4307-aa99-7a60756b314c", "AQAAAAEAACcQAAAAELF69vE8nXUNAZdOYN5c17wrgOsMDZFyG7zO43DvsufN98RDXsm7oPsXzD/Pdmr5LQ==" });
        }
    }
}
