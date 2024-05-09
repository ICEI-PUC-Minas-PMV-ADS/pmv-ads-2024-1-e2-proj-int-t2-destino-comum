using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DestinoComum2.Migrations
{
    /// <inheritdoc />
    public partial class M2Modificando_Nome_TabelaComentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComentarioModel_Cidades_CidadeIdCidade",
                table: "ComentarioModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ComentarioModel_Usuarios_UsuarioId",
                table: "ComentarioModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComentarioModel",
                table: "ComentarioModel");

            migrationBuilder.RenameTable(
                name: "ComentarioModel",
                newName: "Comentarios");

            migrationBuilder.RenameIndex(
                name: "IX_ComentarioModel_UsuarioId",
                table: "Comentarios",
                newName: "IX_Comentarios_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_ComentarioModel_CidadeIdCidade",
                table: "Comentarios",
                newName: "IX_Comentarios_CidadeIdCidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Cidades_CidadeIdCidade",
                table: "Comentarios",
                column: "CidadeIdCidade",
                principalTable: "Cidades",
                principalColumn: "IdCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Usuarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Cidades_CidadeIdCidade",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Usuarios_UsuarioId",
                table: "Comentarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios");

            migrationBuilder.RenameTable(
                name: "Comentarios",
                newName: "ComentarioModel");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "ComentarioModel",
                newName: "IX_ComentarioModel_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_CidadeIdCidade",
                table: "ComentarioModel",
                newName: "IX_ComentarioModel_CidadeIdCidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComentarioModel",
                table: "ComentarioModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComentarioModel_Cidades_CidadeIdCidade",
                table: "ComentarioModel",
                column: "CidadeIdCidade",
                principalTable: "Cidades",
                principalColumn: "IdCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_ComentarioModel_Usuarios_UsuarioId",
                table: "ComentarioModel",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
