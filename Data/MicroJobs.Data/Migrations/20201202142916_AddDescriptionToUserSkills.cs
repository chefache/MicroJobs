using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class AddDescriptionToUserSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserSkills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserSkills");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
