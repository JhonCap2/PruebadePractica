using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebadePractica.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class persona11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Persona_Id",
                table: "InformacionPersona");

            migrationBuilder.AddForeignKey(
                name: "Fk_Persona_Id_Person",
                table: "InformacionPersona",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "IdPerson");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Persona_Id_Person",
                table: "InformacionPersona");

            migrationBuilder.AddForeignKey(
                name: "Fk_Persona_Id",
                table: "InformacionPersona",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "IdPerson");
        }
    }
}
