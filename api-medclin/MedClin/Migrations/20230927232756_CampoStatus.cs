using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedClin.Migrations
{
    /// <inheritdoc />
    public partial class CampoStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Paciente");
        }
    }
}
