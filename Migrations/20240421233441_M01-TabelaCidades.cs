using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DestinoComum.Migrations
{
    /// <inheritdoc />
    public partial class M01TabelaCidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    IdCidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDestino = table.Column<int>(type: "int", nullable: false),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Clima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontoTuristico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alimentacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acessibilidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.IdCidade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}
