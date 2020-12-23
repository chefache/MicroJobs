using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class UpdateWorkerImageAndVoteDeleteBehaviour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerImages_Workers_WorkerId",
                table: "WorkerImages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerVotes_Workers_WorkerId",
                table: "WorkerVotes");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerImages_Workers_WorkerId",
                table: "WorkerImages",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerVotes_Workers_WorkerId",
                table: "WorkerVotes",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerImages_Workers_WorkerId",
                table: "WorkerImages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerVotes_Workers_WorkerId",
                table: "WorkerVotes");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerImages_Workers_WorkerId",
                table: "WorkerImages",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerVotes_Workers_WorkerId",
                table: "WorkerVotes",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
