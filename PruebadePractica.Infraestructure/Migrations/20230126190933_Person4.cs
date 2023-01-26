using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebadePractica.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Person4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdInformacionPersona",
                table: "InformacionPersona",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldUnicode: false,
                oldMaxLength: 500)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdInformacionPersona",
                table: "InformacionPersona",
                type: "int",
                unicode: false,
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
