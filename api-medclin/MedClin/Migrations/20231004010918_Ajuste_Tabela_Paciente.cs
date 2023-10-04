using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedClin.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste_Tabela_Paciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Endereco_Rua",
                table: "Paciente",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "Endereco_Numero",
                table: "Paciente",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "Endereco_Municipio",
                table: "Paciente",
                newName: "Municipio");

            migrationBuilder.RenameColumn(
                name: "Endereco_Estado",
                table: "Paciente",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "Endereco_Complemento",
                table: "Paciente",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "Endereco_Bairro",
                table: "Paciente",
                newName: "Bairro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Paciente",
                newName: "Endereco_Rua");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Paciente",
                newName: "Endereco_Numero");

            migrationBuilder.RenameColumn(
                name: "Municipio",
                table: "Paciente",
                newName: "Endereco_Municipio");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Paciente",
                newName: "Endereco_Estado");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Paciente",
                newName: "Endereco_Complemento");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Paciente",
                newName: "Endereco_Bairro");
        }
    }
}
