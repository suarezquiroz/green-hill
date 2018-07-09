using Microsoft.EntityFrameworkCore.Migrations;

namespace Green_Hill.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RolesUsuario",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Paciente" },
                    { 3, "Empleado" },
                    { 4, "Medico" }
                });

            migrationBuilder.InsertData(
                table: "TiposCita",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { 1, "Medicina General" },
                    { 2, "Odontología" },
                    { 3, "Pediatría" },
                    { 4, "Neurología" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolesUsuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RolesUsuario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RolesUsuario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RolesUsuario",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposCita",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposCita",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposCita",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposCita",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
