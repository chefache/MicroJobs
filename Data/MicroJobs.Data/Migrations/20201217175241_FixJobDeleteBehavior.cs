using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class FixJobDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobImages_Jobs_JobId",
                table: "JobImages");

            migrationBuilder.AddForeignKey(
                name: "FK_JobImages_Jobs_JobId",
                table: "JobImages",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobImages_Jobs_JobId",
                table: "JobImages");

            migrationBuilder.AddForeignKey(
                name: "FK_JobImages_Jobs_JobId",
                table: "JobImages",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
