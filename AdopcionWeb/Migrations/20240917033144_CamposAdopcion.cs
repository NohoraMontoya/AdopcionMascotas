using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdopcionWeb.Migrations
{
    /// <inheritdoc />
    public partial class CamposAdopcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EsAdopcion",
                table: "Mascotas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsAdopcion",
                table: "Mascotas");
        }
    }
}
