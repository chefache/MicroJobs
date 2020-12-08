using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class AddDescriptionToWorkesrSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WorkerSkills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "WorkerSkills");
        }
    }
}
