using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PucPocVS.Migrations
{
    /// <inheritdoc />
    public partial class M7UpdateMentor2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotaMedia",
                table: "Mentores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotaMedia",
                table: "Mentores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 1,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 2,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 3,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 4,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 5,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 6,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 7,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 8,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 9,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 10,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 11,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 12,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 13,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 14,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 15,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 16,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 17,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 18,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 19,
                column: "NotaMedia",
                value: null);

            migrationBuilder.UpdateData(
                table: "Mentores",
                keyColumn: "IdUsuario",
                keyValue: 20,
                column: "NotaMedia",
                value: null);
        }
    }
}
