using Microsoft.EntityFrameworkCore.Migrations;

namespace Webapi2.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatuId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Caseworkers_CaseWorkerId",
                table: "Cases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caseworkers",
                table: "Caseworkers");

            migrationBuilder.DropIndex(
                name: "IX_Cases_CaseStatuId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CaseStatuId",
                table: "Cases");

            migrationBuilder.RenameTable(
                name: "Caseworkers",
                newName: "CaseWorkers");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "CaseStatus",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaseStatusId",
                table: "Cases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaseWorkers",
                table: "CaseWorkers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseStatusId",
                table: "Cases",
                column: "CaseStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatusId",
                table: "Cases",
                column: "CaseStatusId",
                principalTable: "CaseStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseWorkers_CaseWorkerId",
                table: "Cases",
                column: "CaseWorkerId",
                principalTable: "CaseWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatusId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CaseWorkers_CaseWorkerId",
                table: "Cases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaseWorkers",
                table: "CaseWorkers");

            migrationBuilder.DropIndex(
                name: "IX_Cases_CaseStatusId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CaseStatusId",
                table: "Cases");

            migrationBuilder.RenameTable(
                name: "CaseWorkers",
                newName: "Caseworkers");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "CaseStatus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "CaseStatuId",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caseworkers",
                table: "Caseworkers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CaseStatuId",
                table: "Cases",
                column: "CaseStatuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CaseStatus_CaseStatuId",
                table: "Cases",
                column: "CaseStatuId",
                principalTable: "CaseStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Caseworkers_CaseWorkerId",
                table: "Cases",
                column: "CaseWorkerId",
                principalTable: "Caseworkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
