using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroJobs.Data.Migrations
{
    public partial class AddDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Town_TownId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_AspNetUsers_UserId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Job_JobId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Portfolio_PortfolioId1",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_AspNetUsers_UserId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_JobSubCategory_JobSubCategoryId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTown_Job_JobId",
                table: "JobTown");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTown_Town_TownId",
                table: "JobTown");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolio_AspNetUsers_UserId",
                table: "Portfolio");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_AspNetUsers_UserId",
                table: "UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_Skill_SkillId",
                table: "UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallet_AspNetUsers_UserId",
                table: "Wallet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wallet",
                table: "Wallet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkill",
                table: "UserSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Town",
                table: "Town");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTown",
                table: "JobTown");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSubCategory",
                table: "JobSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_IsDeleted",
                table: "Job");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Job");

            migrationBuilder.RenameTable(
                name: "Wallet",
                newName: "Wallets");

            migrationBuilder.RenameTable(
                name: "UserSkill",
                newName: "UserSkills");

            migrationBuilder.RenameTable(
                name: "Town",
                newName: "Towns");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.RenameTable(
                name: "Portfolio",
                newName: "Portfolios");

            migrationBuilder.RenameTable(
                name: "JobTown",
                newName: "JobTowns");

            migrationBuilder.RenameTable(
                name: "JobSubCategory",
                newName: "JobSubCategories");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "Jobs");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.RenameIndex(
                name: "IX_Wallet_UserId",
                table: "Wallets",
                newName: "IX_Wallets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Wallet_IsDeleted",
                table: "Wallets",
                newName: "IX_Wallets_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkill_UserId",
                table: "UserSkills",
                newName: "IX_UserSkills_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkill_SkillId",
                table: "UserSkills",
                newName: "IX_UserSkills_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkill_IsDeleted",
                table: "UserSkills",
                newName: "IX_UserSkills_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Town_IsDeleted",
                table: "Towns",
                newName: "IX_Towns_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Skill_IsDeleted",
                table: "Skills",
                newName: "IX_Skills_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolio_UserId",
                table: "Portfolios",
                newName: "IX_Portfolios_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolio_IsDeleted",
                table: "Portfolios",
                newName: "IX_Portfolios_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_JobTown_TownId",
                table: "JobTowns",
                newName: "IX_JobTowns_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTown_JobId",
                table: "JobTowns",
                newName: "IX_JobTowns_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTown_IsDeleted",
                table: "JobTowns",
                newName: "IX_JobTowns_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_JobSubCategory_IsDeleted",
                table: "JobSubCategories",
                newName: "IX_JobSubCategories_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Job_UserId",
                table: "Jobs",
                newName: "IX_Jobs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Job_JobSubCategoryId",
                table: "Jobs",
                newName: "IX_Jobs_JobSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_UserId",
                table: "Images",
                newName: "IX_Images_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_PortfolioId1",
                table: "Images",
                newName: "IX_Images_PortfolioId1");

            migrationBuilder.RenameIndex(
                name: "IX_Image_JobId",
                table: "Images",
                newName: "IX_Images_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_IsDeleted",
                table: "Images",
                newName: "IX_Images_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wallets",
                table: "Wallets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTowns",
                table: "JobTowns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSubCategories",
                table: "JobSubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "JobSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSkills_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_IsDeleted",
                table: "JobSkills",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_JobId",
                table: "JobSkills",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_SkillId",
                table: "JobSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Towns_TownId",
                table: "AspNetUsers",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_UserId",
                table: "Images",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Jobs_JobId",
                table: "Images",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Portfolios_PortfolioId1",
                table: "Images",
                column: "PortfolioId1",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_UserId",
                table: "Jobs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobSubCategories_JobSubCategoryId",
                table: "Jobs",
                column: "JobSubCategoryId",
                principalTable: "JobSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTowns_Jobs_JobId",
                table: "JobTowns",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTowns_Towns_TownId",
                table: "JobTowns",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_AspNetUsers_UserId",
                table: "UserSkills",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Towns_TownId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_UserId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Jobs_JobId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Portfolios_PortfolioId1",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_UserId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobSubCategories_JobSubCategoryId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTowns_Jobs_JobId",
                table: "JobTowns");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTowns_Towns_TownId",
                table: "JobTowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_AspNetUsers_UserId",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets");

            migrationBuilder.DropTable(
                name: "JobSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wallets",
                table: "Wallets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTowns",
                table: "JobTowns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSubCategories",
                table: "JobSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.RenameTable(
                name: "Wallets",
                newName: "Wallet");

            migrationBuilder.RenameTable(
                name: "UserSkills",
                newName: "UserSkill");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "Town");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.RenameTable(
                name: "Portfolios",
                newName: "Portfolio");

            migrationBuilder.RenameTable(
                name: "JobTowns",
                newName: "JobTown");

            migrationBuilder.RenameTable(
                name: "JobSubCategories",
                newName: "JobSubCategory");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "Job");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.RenameIndex(
                name: "IX_Wallets_UserId",
                table: "Wallet",
                newName: "IX_Wallet_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Wallets_IsDeleted",
                table: "Wallet",
                newName: "IX_Wallet_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_UserId",
                table: "UserSkill",
                newName: "IX_UserSkill_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkill",
                newName: "IX_UserSkill_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSkills_IsDeleted",
                table: "UserSkill",
                newName: "IX_UserSkill_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_IsDeleted",
                table: "Town",
                newName: "IX_Town_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_IsDeleted",
                table: "Skill",
                newName: "IX_Skill_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolio",
                newName: "IX_Portfolio_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_IsDeleted",
                table: "Portfolio",
                newName: "IX_Portfolio_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_JobTowns_TownId",
                table: "JobTown",
                newName: "IX_JobTown_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTowns_JobId",
                table: "JobTown",
                newName: "IX_JobTown_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTowns_IsDeleted",
                table: "JobTown",
                newName: "IX_JobTown_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_JobSubCategories_IsDeleted",
                table: "JobSubCategory",
                newName: "IX_JobSubCategory_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_UserId",
                table: "Job",
                newName: "IX_Job_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_JobSubCategoryId",
                table: "Job",
                newName: "IX_Job_JobSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_UserId",
                table: "Image",
                newName: "IX_Image_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_PortfolioId1",
                table: "Image",
                newName: "IX_Image_PortfolioId1");

            migrationBuilder.RenameIndex(
                name: "IX_Images_JobId",
                table: "Image",
                newName: "IX_Image_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_IsDeleted",
                table: "Image",
                newName: "IX_Image_IsDeleted");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Job",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wallet",
                table: "Wallet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkill",
                table: "UserSkill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Town",
                table: "Town",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTown",
                table: "JobTown",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSubCategory",
                table: "JobSubCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Job",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Job_IsDeleted",
                table: "Job",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Town_TownId",
                table: "AspNetUsers",
                column: "TownId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_AspNetUsers_UserId",
                table: "Image",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Job_JobId",
                table: "Image",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Portfolio_PortfolioId1",
                table: "Image",
                column: "PortfolioId1",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_AspNetUsers_UserId",
                table: "Job",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_JobSubCategory_JobSubCategoryId",
                table: "Job",
                column: "JobSubCategoryId",
                principalTable: "JobSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTown_Job_JobId",
                table: "JobTown",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTown_Town_TownId",
                table: "JobTown",
                column: "TownId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_AspNetUsers_UserId",
                table: "Portfolio",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_AspNetUsers_UserId",
                table: "UserSkill",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_Skill_SkillId",
                table: "UserSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallet_AspNetUsers_UserId",
                table: "Wallet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
