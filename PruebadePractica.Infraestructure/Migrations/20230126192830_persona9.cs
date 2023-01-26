using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebadePractica.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class persona9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "InformacionPersona",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "IdPerson",
                table: "InformacionPersona",
                newName: "PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionPersona_IdPerson",
                table: "InformacionPersona",
                newName: "IX_InformacionPersona_PersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "InformacionPersona",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "InformacionPersona",
                newName: "IdPerson");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionPersona_PersonaId",
                table: "InformacionPersona",
                newName: "IX_InformacionPersona_IdPerson");
        }
    }
}
