using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class FixJobDeleteBehaviorInVote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobVotes_Jobs_JobId",
                table: "JobVotes");

            migrationBuilder.AddForeignKey(
                name: "FK_JobVotes_Jobs_JobId",
                table: "JobVotes",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobVotes_Jobs_JobId",
                table: "JobVotes");

            migrationBuilder.AddForeignKey(
                name: "FK_JobVotes_Jobs_JobId",
                table: "JobVotes",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
