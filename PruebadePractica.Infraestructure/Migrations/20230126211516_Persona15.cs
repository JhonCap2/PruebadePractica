using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebadePractica.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Persona15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPerson",
                table: "InformacionPersona",
                newName: "IdPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionPersona_IdPerson",
                table: "InformacionPersona",
                newName: "IX_InformacionPersona_IdPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPersonId",
                table: "InformacionPersona",
                newName: "IdPerson");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionPersona_IdPersonId",
                table: "InformacionPersona",
                newName: "IX_InformacionPersona_IdPerson");
        }
    }
}
