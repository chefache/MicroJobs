namespace MicroJobs.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ChangeTownFromColumnInEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Towns_TownId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "JobTowns");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TownId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "AspNetUsers",
                newName: "Town");

            migrationBuilder.AddColumn<int>(
                name: "Town",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Town",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Town",
                table: "AspNetUsers",
                newName: "TownId");

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JobId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TownId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTowns_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobTowns_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TownId",
                table: "AspNetUsers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTowns_IsDeleted",
                table: "JobTowns",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_JobTowns_JobId",
                table: "JobTowns",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTowns_TownId",
                table: "JobTowns",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_IsDeleted",
                table: "Towns",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Towns_TownId",
                table: "AspNetUsers",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
