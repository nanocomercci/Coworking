using Microsoft.EntityFrameworkCore.Migrations;

namespace Coworking.Api.DataAccess.Migrations
{
    public partial class ChangeAdminEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Offices_Id",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Offices",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Admins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_AdminId",
                table: "Offices",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offices_Admins_AdminId",
                table: "Offices",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offices_Admins_AdminId",
                table: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Offices_AdminId",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Offices");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Admins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Offices_Id",
                table: "Admins",
                column: "Id",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
