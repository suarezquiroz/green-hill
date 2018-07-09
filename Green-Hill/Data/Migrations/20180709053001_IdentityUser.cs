using Microsoft.EntityFrameworkCore.Migrations;

namespace Green_Hill.Data.Migrations
{
    public partial class IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_ApplicationUser_ApplicationUserId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Usuarios",
                newName: "IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_ApplicationUserId",
                table: "Usuarios",
                newName: "IX_Usuarios_IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_AspNetUsers_IdentityUserId",
                table: "Usuarios",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_AspNetUsers_IdentityUserId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "Usuarios",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdentityUserId",
                table: "Usuarios",
                newName: "IX_Usuarios_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
