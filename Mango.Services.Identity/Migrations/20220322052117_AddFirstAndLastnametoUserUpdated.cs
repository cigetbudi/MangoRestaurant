using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.Identity.Migrations
{
    public partial class AddFirstAndLastnametoUserUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "AspNetUsers",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Firstname");
        }
    }
}
