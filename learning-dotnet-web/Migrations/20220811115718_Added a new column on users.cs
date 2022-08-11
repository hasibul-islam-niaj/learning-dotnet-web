using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace learning_dotnet_web.Migrations
{
    public partial class Addedanewcolumnonusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Users",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Users");
        }
    }
}
