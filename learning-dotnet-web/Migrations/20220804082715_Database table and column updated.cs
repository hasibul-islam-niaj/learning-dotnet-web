using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace learning_dotnet_web.Migrations
{
    public partial class Databasetableandcolumnupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pphone1",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Name1",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Email1",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "Users",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "Pphone1");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Name1");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Email1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "Id1");
        }
    }
}
