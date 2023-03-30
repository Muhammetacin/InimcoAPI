using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inimco.Migrations
{
    /// <inheritdoc />
    public partial class SocialSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccount_Persons_PersonId",
                table: "SocialAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialSkill_Persons_PersonId",
                table: "SocialSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialSkill",
                table: "SocialSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialAccount",
                table: "SocialAccount");

            migrationBuilder.RenameTable(
                name: "SocialSkill",
                newName: "SocialSkills");

            migrationBuilder.RenameTable(
                name: "SocialAccount",
                newName: "SocialAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_SocialSkill_PersonId",
                table: "SocialSkills",
                newName: "IX_SocialSkills_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_SocialAccount_PersonId",
                table: "SocialAccounts",
                newName: "IX_SocialAccounts_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialSkills",
                table: "SocialSkills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialAccounts",
                table: "SocialAccounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_Persons_PersonId",
                table: "SocialAccounts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialSkills_Persons_PersonId",
                table: "SocialSkills",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_Persons_PersonId",
                table: "SocialAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialSkills_Persons_PersonId",
                table: "SocialSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialSkills",
                table: "SocialSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialAccounts",
                table: "SocialAccounts");

            migrationBuilder.RenameTable(
                name: "SocialSkills",
                newName: "SocialSkill");

            migrationBuilder.RenameTable(
                name: "SocialAccounts",
                newName: "SocialAccount");

            migrationBuilder.RenameIndex(
                name: "IX_SocialSkills_PersonId",
                table: "SocialSkill",
                newName: "IX_SocialSkill_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_SocialAccounts_PersonId",
                table: "SocialAccount",
                newName: "IX_SocialAccount_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialSkill",
                table: "SocialSkill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialAccount",
                table: "SocialAccount",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccount_Persons_PersonId",
                table: "SocialAccount",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialSkill_Persons_PersonId",
                table: "SocialSkill",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
