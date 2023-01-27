using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebadePractica.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class PersonaPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamesPerson = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    LastNamesPerson = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Identity = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.IdPerson);
                });

            migrationBuilder.CreateTable(
                name: "InformacionPersona",
                columns: table => new
                {
                    IdInformacionPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPersonId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", unicode: false, maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Work = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionPersona", x => x.IdInformacionPersona);
                    table.ForeignKey(
                        name: "Fk_Persona_Id_Person",
                        column: x => x.IdPersonId,
                        principalTable: "Persona",
                        principalColumn: "IdPerson");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformacionPersona_IdPersonId",
                table: "InformacionPersona",
                column: "IdPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionPersona");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
