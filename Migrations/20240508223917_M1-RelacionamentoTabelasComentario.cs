using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DestinoComum2.Migrations
{
    /// <inheritdoc />
    public partial class M1RelacionamentoTabelasComentario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComentarioModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CidadeComentarioId = table.Column<int>(type: "int", nullable: false),
                    CidadeIdCidade = table.Column<int>(type: "int", nullable: true),
                    DataComentario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacaoComentario = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComentarioModel_Cidades_CidadeIdCidade",
                        column: x => x.CidadeIdCidade,
                        principalTable: "Cidades",
                        principalColumn: "IdCidade");
                    table.ForeignKey(
                        name: "FK_ComentarioModel_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioModel_CidadeIdCidade",
                table: "ComentarioModel",
                column: "CidadeIdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioModel_UsuarioId",
                table: "ComentarioModel",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentarioModel");
        }
    }
}
