using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp.CodeFirst.Migrations
{
    public partial class phoneAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PersonInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PersonInfos");
        }
    }
}
