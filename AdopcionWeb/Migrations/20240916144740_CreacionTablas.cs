using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdopcionWeb.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FechaEncontrado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaPosibleNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoMascota = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PosiblesEnfermedades = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Caracteristicas = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EsValido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DescripcionHogar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EsValido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adopciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MascotaId = table.Column<long>(type: "bigint", nullable: false),
                    PersonaId = table.Column<long>(type: "bigint", nullable: false),
                    FechaAdopcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaTerminoSeguimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adopciones_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adopciones_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdopcionId = table.Column<long>(type: "bigint", nullable: false),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondicionesMascota = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitas_Adopciones_AdopcionId",
                        column: x => x.AdopcionId,
                        principalTable: "Adopciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adopciones_MascotaId",
                table: "Adopciones",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Adopciones_PersonaId",
                table: "Adopciones",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_AdopcionId",
                table: "Visitas",
                column: "AdopcionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Adopciones");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
