using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Green_Hill.Data.Migrations
{
    public partial class oneContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "RolesUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolesUsuario",
                table: "RolesUsuario",
                column: "Id");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_RolesUsuario_RolId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "TiposCita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolesUsuario",
                table: "RolesUsuario");

            migrationBuilder.RenameTable(
                name: "RolesUsuario",
                newName: "Roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol",
                table: "Roles",
                column: "Id");

        }
    }
}
