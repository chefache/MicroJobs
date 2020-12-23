using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class UpdateWorkerSkillsDeleteBehaviour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerSkills_Workers_WorkerId",
                table: "WorkerSkills");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerSkills_Workers_WorkerId",
                table: "WorkerSkills",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerSkills_Workers_WorkerId",
                table: "WorkerSkills");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerSkills_Workers_WorkerId",
                table: "WorkerSkills",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
